/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace OilPaintingCartoonFilter
{
    public static class ExtBitmap
    {
        public static Bitmap CopyToSquareCanvas(this Bitmap sourceBitmap, int canvasWidthLenght)
        {
            float ratio = 1.0f;
            int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                          sourceBitmap.Width : sourceBitmap.Height;

            ratio = (float)maxSide / (float)canvasWidthLenght;

            Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                    new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                    : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

            using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
            {
                graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                graphicsResult.DrawImage(sourceBitmap,
                                        new Rectangle(0, 0,
                                            bitmapResult.Width, bitmapResult.Height),
                                        new Rectangle(0, 0,
                                            sourceBitmap.Width, sourceBitmap.Height),
                                            GraphicsUnit.Pixel);
                graphicsResult.Flush();
            }

            return bitmapResult;
        }

        public static Bitmap CartoonFilter(this Bitmap sourceBitmap,
                                               int levels,
                                               int filterSize,
                                               byte threshold)
        {
            Bitmap paintFilterImage = 
                   sourceBitmap.OilPaintFilter(levels, filterSize);

            Bitmap edgeDetectImage = 
                sourceBitmap.GradientBasedEdgeDetectionFilter(threshold);

            BitmapData paintData =
                       paintFilterImage.LockBits(new Rectangle(0, 0,
                       paintFilterImage.Width, paintFilterImage.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] paintPixelBuffer = new byte[paintData.Stride *
                                              paintData.Height];

            Marshal.Copy(paintData.Scan0, paintPixelBuffer, 0,
                                       paintPixelBuffer.Length);

            paintFilterImage.UnlockBits(paintData);

            BitmapData edgeData =
                       edgeDetectImage.LockBits(new Rectangle(0, 0,
                       edgeDetectImage.Width, edgeDetectImage.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] edgePixelBuffer = new byte[edgeData.Stride *
                                             edgeData.Height];

            Marshal.Copy(edgeData.Scan0, edgePixelBuffer, 0,
                                      edgePixelBuffer.Length);

            edgeDetectImage.UnlockBits(edgeData);

            byte[] resultBuffer = new byte[edgeData.Stride *
                                             edgeData.Height];

            for (int k = 0; k + 4 < paintPixelBuffer.Length; k += 4)
            {
                if (edgePixelBuffer[k] == 255 || 
                    edgePixelBuffer[k + 1] == 255 || 
                    edgePixelBuffer[k + 2] == 255)
                {
                    resultBuffer[k] = 0;
                    resultBuffer[k + 1] = 0;
                    resultBuffer[k + 2] = 0;
                    resultBuffer[k + 3] = 255;
                }
                else
                {
                    resultBuffer[k] = paintPixelBuffer[k];
                    resultBuffer[k + 1] = paintPixelBuffer[k + 1];
                    resultBuffer[k + 2] = paintPixelBuffer[k + 2];
                    resultBuffer[k + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);

            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap OilPaintFilter(this Bitmap sourceBitmap,
                                               int levels,
                                               int filterSize)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            byte[] resultBuffer = new byte[sourceData.Stride *
                                           sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            int[] intensityBin = new int[levels];
            int[] blueBin = new int[levels];
            int[] greenBin = new int[levels];
            int[] redBin = new int[levels];

            levels = levels - 1;

            int filterOffset = (filterSize - 1) / 2;
            int byteOffset = 0;
            int calcOffset = 0;
            int currentIntensity = 0;
            int maxIntensity = 0;
            int maxIndex = 0;

            double blue = 0;
            double green = 0;
            double red = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = green = red = 0;

                    currentIntensity = maxIntensity = maxIndex = 0;

                    intensityBin = new int[levels + 1];
                    blueBin = new int[levels + 1];
                    greenBin = new int[levels + 1];
                    redBin = new int[levels + 1];

                    byteOffset = offsetY *
                    sourceData.Stride + offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            currentIntensity = (int)Math.Round(((double)
                                       (pixelBuffer[calcOffset] +
                                       pixelBuffer[calcOffset + 1] +
                                       pixelBuffer[calcOffset + 2]) / 3.0 *
                                       (levels)) / 255.0);

                            intensityBin[currentIntensity] += 1;
                            blueBin[currentIntensity] += pixelBuffer[calcOffset];
                            greenBin[currentIntensity] += pixelBuffer[calcOffset + 1];
                            redBin[currentIntensity] += pixelBuffer[calcOffset + 2];

                            if (intensityBin[currentIntensity] > maxIntensity)
                            {
                                maxIntensity = intensityBin[currentIntensity];
                                maxIndex = currentIntensity;
                            }
                        }
                    }

                    blue = blueBin[maxIndex] / maxIntensity;
                    green = greenBin[maxIndex] / maxIntensity;
                    red = redBin[maxIndex] / maxIntensity;

                    resultBuffer[byteOffset] = ClipByte(blue);
                    resultBuffer[byteOffset + 1] = ClipByte(green);
                    resultBuffer[byteOffset + 2] = ClipByte(red);
                    resultBuffer[byteOffset + 3] = 255;

                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                             sourceBitmap.Height);

            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                       ImageLockMode.WriteOnly,
                       PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap GradientBasedEdgeDetectionFilter(
                                this Bitmap sourceBitmap,
                                byte threshold = 0)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            int sourceOffset = 0, gradientValue = 0;
            bool exceedsThreshold = false;

            for (int offsetY = 1; offsetY < sourceBitmap.Height - 1; offsetY++)
            {
                for (int offsetX = 1; offsetX < sourceBitmap.Width - 1; offsetX++)
                {
                    sourceOffset = offsetY * sourceData.Stride + offsetX * 4;
                    gradientValue = 0;
                    exceedsThreshold = true;

                    // Horizontal Gradient
                    CheckThreshold(pixelBuffer, 
                                   sourceOffset - 4, 
                                   sourceOffset + 4, 
                                   ref gradientValue, threshold, 2);
                    // Vertical Gradient
                    exceedsThreshold = 
                    CheckThreshold(pixelBuffer, 
                                   sourceOffset - sourceData.Stride, 
                                   sourceOffset + sourceData.Stride, 
                                   ref gradientValue, threshold, 2);

                    if (exceedsThreshold == false)
                    {
                        gradientValue = 0;

                        // Horizontal Gradient
                        exceedsThreshold = 
                        CheckThreshold(pixelBuffer, 
                                       sourceOffset - 4, 
                                       sourceOffset + 4, 
                                       ref gradientValue, threshold);

                        if (exceedsThreshold == false)
                        {
                            gradientValue = 0;

                            // Vertical Gradient
                            exceedsThreshold = 
                            CheckThreshold(pixelBuffer, 
                                           sourceOffset - sourceData.Stride, 
                                           sourceOffset + sourceData.Stride, 
                                           ref gradientValue, threshold);

                            if (exceedsThreshold == false)
                            {
                                gradientValue = 0;

                                // Diagonal Gradient : NW-SE
                                CheckThreshold(pixelBuffer, 
                                               sourceOffset - 4 - sourceData.Stride, 
                                               sourceOffset + 4 + sourceData.Stride, 
                                               ref gradientValue, threshold, 2);
                                // Diagonal Gradient : NE-SW
                                exceedsThreshold = 
                                CheckThreshold(pixelBuffer, 
                                               sourceOffset - sourceData.Stride + 4, 
                                               sourceOffset - 4 + sourceData.Stride, 
                                               ref gradientValue, threshold, 2);

                                if (exceedsThreshold == false)
                                {
                                    gradientValue = 0;

                                    // Diagonal Gradient : NW-SE
                                    exceedsThreshold = 
                                    CheckThreshold(pixelBuffer, 
                                                   sourceOffset - 4 - sourceData.Stride, 
                                                   sourceOffset + 4 + sourceData.Stride, 
                                                   ref gradientValue, threshold);

                                    if (exceedsThreshold == false)
                                    {
                                        gradientValue = 0;

                                        // Diagonal Gradient : NE-SW
                                        exceedsThreshold = 
                                        CheckThreshold(pixelBuffer, 
                                                       sourceOffset - sourceData.Stride + 4, 
                                                       sourceOffset + sourceData.Stride - 4, 
                                                       ref gradientValue, threshold);
                                    }
                                }
                            }
                        }
                    }

                    resultBuffer[sourceOffset] = (byte)(exceedsThreshold ? 255 : 0);
                    resultBuffer[sourceOffset + 1] = resultBuffer[sourceOffset];
                    resultBuffer[sourceOffset + 2] = resultBuffer[sourceOffset];
                    resultBuffer[sourceOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                    resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static bool CheckThreshold(byte[] pixelBuffer, 
                                           int offset1, int offset2, 
                                           ref int gradientValue, 
                                           byte threshold, 
                                           int divideBy = 1)
        {
            gradientValue +=
            Math.Abs(pixelBuffer[offset1] -
            pixelBuffer[offset2]) / divideBy;

            gradientValue +=
            Math.Abs(pixelBuffer[offset1 + 1] -
            pixelBuffer[offset2 + 1]) / divideBy;

            gradientValue +=
            Math.Abs(pixelBuffer[offset1 + 2] -
            pixelBuffer[offset2 + 2]) / divideBy;

            return (gradientValue >= threshold);
        }

        private static byte ClipByte(double colour)
        {
            return (byte)(colour > 255 ? 255 : 
                   (colour < 0 ? 0 : colour));
        }
    }
}

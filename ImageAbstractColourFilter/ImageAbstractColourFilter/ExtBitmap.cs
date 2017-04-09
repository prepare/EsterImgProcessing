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

namespace ImageAbstractColourFilter
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

        public static byte[] GetByteArray(this Bitmap sourceBitmap)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] sourceBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            Marshal.Copy(sourceData.Scan0, sourceBuffer, 0,
                                       sourceBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            return sourceBuffer;
        }

        public static Bitmap AbstractColorsFilter(this Bitmap sourceBitmap,
                                                  int matrixSize,
                                                  byte edgeThreshold,
                                                  bool applyBlue = true,
                                                  bool applyGreen = true,
                                                  bool applyRed = true,
                                                  EdgeTracingType edgeType = 
                                                  EdgeTracingType.Black,
                                                  ColorShiftType shiftType =
                                                  ColorShiftType.None)
        {
            Bitmap edgeBitmap = 
            sourceBitmap.GradientBasedEdgeDetectionFilter(edgeThreshold);

            Bitmap colorBitmap = 
            sourceBitmap.AverageColoursFilter(matrixSize, 
                         applyBlue, applyGreen, applyRed, shiftType);

            byte[] edgeBuffer = edgeBitmap.GetByteArray();
            byte[] colorBuffer = colorBitmap.GetByteArray();
            byte[] resultBuffer = colorBitmap.GetByteArray();

            for (int k = 0; k + 4 < edgeBuffer.Length; k += 4)
            {
                if (edgeBuffer[k] == 255)
                {
                    switch (edgeType)
                    {
                        case EdgeTracingType.Black:
                            resultBuffer[k] = 0;
                            resultBuffer[k+1] = 0;
                            resultBuffer[k+2] = 0;
                            break;
                        case EdgeTracingType.White:
                            resultBuffer[k] = 255;
                            resultBuffer[k+1] = 255;
                            resultBuffer[k+2] = 255;
                            break;
                        case EdgeTracingType.HalfIntensity:
                            resultBuffer[k] = ClipByte(resultBuffer[k] * 0.5);
                            resultBuffer[k + 1] = ClipByte(resultBuffer[k + 1] * 0.5);
                            resultBuffer[k + 2] = ClipByte(resultBuffer[k + 2] * 0.5);
                            break;
                        case EdgeTracingType.DoubleIntensity:
                            resultBuffer[k] = ClipByte(resultBuffer[k] * 2);
                            resultBuffer[k + 1] = ClipByte(resultBuffer[k + 1] * 2);
                            resultBuffer[k + 2] = ClipByte(resultBuffer[k + 2] * 2);
                            break;
                        case EdgeTracingType.ColorInversion:
                            resultBuffer[k] = ClipByte(255 - resultBuffer[k]);
                            resultBuffer[k+1] = ClipByte(255 - resultBuffer[k+1]);
                            resultBuffer[k+2] = ClipByte(255 - resultBuffer[k+2]);
                            break;
                    }
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

        public static Bitmap AverageColoursFilter(this Bitmap sourceBitmap, 
                                                  int matrixSize,  
                                                  bool applyBlue = true,
                                                  bool applyGreen = true,
                                                  bool applyRed = true,
                                                  ColorShiftType shiftType =
                                                  ColorShiftType.None) 
        {
            byte[] pixelBuffer = sourceBitmap.GetByteArray();
            byte[] resultBuffer = new byte[pixelBuffer.Length];

            int calcOffset = 0;
            int byteOffset = 0;
            int blue = 0; int green = 0; int red = 0;
            int filterOffset = (matrixSize - 1) / 2;

            for (int offsetY = filterOffset; offsetY < 
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < 
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY * sourceBitmap.Width*4 + 
                                 offsetX * 4;

                    blue = 0; green = 0; red = 0;

                    for (int filterY = -filterOffset; 
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + 
                            (filterX * 4) +
                            (filterY * sourceBitmap.Width * 4);

                            blue += pixelBuffer[calcOffset];
                            green += pixelBuffer[calcOffset + 1];
                            red += pixelBuffer[calcOffset + 2];
                        }
                    }

                    blue = blue / matrixSize;
                    green = green / matrixSize;
                    red = red / matrixSize;

                    if (applyBlue == false)
                    { blue = pixelBuffer[byteOffset]; }

                    if (applyGreen == false)
                    { green = pixelBuffer[byteOffset + 1]; }

                    if (applyRed == false)
                    { red = pixelBuffer[byteOffset + 2]; }

                    if (shiftType == ColorShiftType.None)
                    {
                        resultBuffer[byteOffset] = (byte)blue;
                        resultBuffer[byteOffset + 1] = (byte)green;
                        resultBuffer[byteOffset + 2] = (byte)red;
                        resultBuffer[byteOffset + 3] = 255;
                    }
                    else if (shiftType == ColorShiftType.ShiftLeft)
                    {
                        resultBuffer[byteOffset] = (byte)green;
                        resultBuffer[byteOffset + 1] = (byte)red;
                        resultBuffer[byteOffset + 2] = (byte)blue;
                        resultBuffer[byteOffset + 3] = 255;
                    }
                    else if (shiftType == ColorShiftType.ShiftRight)
                    {
                        resultBuffer[byteOffset] = (byte)red;
                        resultBuffer[byteOffset + 1] = (byte)blue;
                        resultBuffer[byteOffset + 2] = (byte)green;
                        resultBuffer[byteOffset + 3] = 255;
                    }
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

            for (int offsetY = 1; offsetY < 
                                  sourceBitmap.Height - 1; offsetY++)
            {
                for (int offsetX = 1; offsetX < 
                                      sourceBitmap.Width - 1; offsetX++)
                {
                    sourceOffset = offsetY * sourceData.Stride +
                                   offsetX * 4;
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

        public enum ColorShiftType
        {
            None,
            ShiftLeft,
            ShiftRight
        }

        public enum EdgeTracingType
        {
            Black,
            White,
            HalfIntensity,
            DoubleIntensity,
            ColorInversion
        }
    }  
}

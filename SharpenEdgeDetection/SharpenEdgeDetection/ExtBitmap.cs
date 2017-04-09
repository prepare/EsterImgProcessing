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

namespace SharpenEdgeDetection
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

        public static Bitmap SharpenEdgeDetect(this Bitmap sourceBitmap,
                                                    SharpenType sharpen,
                                                           int bias = 0,
                                                 bool grayscale = false,
                                                      bool mono = false,
                                               int medianFilterSize = 0)
        {
            Bitmap resultBitmap = null;

            if (medianFilterSize == 0)
            {
                resultBitmap = sourceBitmap;
            }
            else
            {
                resultBitmap = 
                sourceBitmap.MedianFilter(medianFilterSize);
            }
            
            switch (sharpen)
            {
                case SharpenType.Sharpen7To1:
                    {
                        resultBitmap = 
                        resultBitmap.SharpenEdgeDetect(
                                     Matrix.Sharpen7To1, 
                                     1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen9To1:
                    {
                        resultBitmap = 
                            resultBitmap.SharpenEdgeDetect(
                                        Matrix.Sharpen9To1, 
                                        1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen12To1:
                    {
                        resultBitmap = 
                            resultBitmap.SharpenEdgeDetect(
                                        Matrix.Sharpen12To1, 
                                        1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen24To1:
                    {
                        resultBitmap = 
                        resultBitmap.SharpenEdgeDetect(
                                    Matrix.Sharpen24To1, 
                                    1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen48To1:
                    {
                        resultBitmap = 
                        resultBitmap.SharpenEdgeDetect(
                                    Matrix.Sharpen48To1, 
                                    1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen5To4:
                    {
                        resultBitmap = 
                        resultBitmap.SharpenEdgeDetect(
                                    Matrix.Sharpen5To4, 
                                    1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen10To8:
                    {
                        resultBitmap = 
                        resultBitmap.SharpenEdgeDetect(
                                    Matrix.Sharpen10To8, 
                                    1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen11To8:
                    {
                        resultBitmap = 
                        resultBitmap.SharpenEdgeDetect(
                                    Matrix.Sharpen11To8, 
                                    3.0 / 1.0, bias, grayscale, mono);
                    } break;
                case SharpenType.Sharpen821:
                    {
                        resultBitmap = 
                        resultBitmap.SharpenEdgeDetect(
                                    Matrix.Sharpen821, 
                                    8.0 / 1.0, bias, grayscale, mono);
                    } break;
            }

            return resultBitmap;
        }

        private static Bitmap SharpenEdgeDetect(this Bitmap sourceBitmap,
                                                  double[,] filterMatrix,
                                                       double factor = 1,
                                                            int bias = 0,
                                                  bool grayscale = false,
                                                       bool mono = false)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                 PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            if (grayscale == true)
            {
                for (int pixel = 0; pixel < pixelBuffer.Length; pixel += 4)
                {
                    pixelBuffer[pixel] = 
                        (byte)(pixelBuffer[pixel] * 0.11f);

                    pixelBuffer[pixel + 1] = 
                        (byte)(pixelBuffer[pixel + 1] * 0.59f);

                    pixelBuffer[pixel + 2] = 
                        (byte)(pixelBuffer[pixel + 2] * 0.3f);

                }
            }

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            blue += (double)(pixelBuffer[calcOffset]) *
                                    filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            green += (double)(pixelBuffer[calcOffset + 1]) *
                                     filterMatrix[filterY + filterOffset,
                                                        filterX + filterOffset];

                            red += (double)(pixelBuffer[calcOffset + 2]) *
                                   filterMatrix[filterY + filterOffset,
                                                      filterX + filterOffset];
                        }
                    }

                    if (mono == true)
                    {
                        blue = resultBuffer[byteOffset] - factor * blue;
                        green = resultBuffer[byteOffset + 1] - factor * green;
                        red = resultBuffer[byteOffset + 2] - factor * red;

                        blue = (blue > bias ? 255 : 0);

                        green = (blue > bias ? 255 : 0);

                        red = (blue > bias ? 255 : 0);
                    }
                    else
                    {
                        blue = resultBuffer[byteOffset] - 
                               factor * blue + bias;

                        green = resultBuffer[byteOffset + 1] - 
                                factor * green + bias;

                        red = resultBuffer[byteOffset + 2] - 
                              factor * red + bias;

                        blue = (blue > 255 ? 255 :
                               (blue < 0 ? 0 :
                                blue));

                        green = (green > 255 ? 255 :
                                (green < 0 ? 0 :
                                 green));

                        red = (red > 255 ? 255 :
                              (red < 0 ? 0 :
                               red));
                    }

                        

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                     resultBitmap.Width, resultBitmap.Height),
                                                      ImageLockMode.WriteOnly,
                                                 PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public enum SharpenType
        {
            None,
            Sharpen7To1,
            Sharpen9To1,
            Sharpen12To1,
            Sharpen24To1,
            Sharpen48To1,
            Sharpen5To4,
            Sharpen10To8,
            Sharpen11To8,
            Sharpen821
        }

        public static Bitmap MedianFilter(this Bitmap sourceBitmap,
                                          int matrixSize)
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

            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;

            int byteOffset = 0;

            List<int> neighbourPixels = new List<int>();
            byte[] middlePixel;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *
                                 sourceData.Stride +
                                 offsetX * 4;

                    neighbourPixels.Clear();

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset +
                                         (filterX * 4) +
                                         (filterY * sourceData.Stride);

                            neighbourPixels.Add(BitConverter.ToInt32(
                                             pixelBuffer, calcOffset));
                        }
                    }

                    neighbourPixels.Sort();

                    middlePixel = BitConverter.GetBytes(
                                       neighbourPixels[filterOffset]);

                    resultBuffer[byteOffset] = middlePixel[0];
                    resultBuffer[byteOffset + 1] = middlePixel[1];
                    resultBuffer[byteOffset + 2] = middlePixel[2];
                    resultBuffer[byteOffset + 3] = middlePixel[3];
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
    }  
}

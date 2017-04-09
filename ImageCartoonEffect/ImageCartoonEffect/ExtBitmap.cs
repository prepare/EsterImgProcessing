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

namespace ImageCartoonEffect
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
        
        public static Bitmap CartoonEffectFilter(
                                        this Bitmap sourceBitmap,
                                        byte threshold = 0,
                                        SmoothingFilterType smoothFilter 
                                        = SmoothingFilterType.None)
        {


            sourceBitmap = sourceBitmap.SmoothingFilter(smoothFilter);
            
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

            int byteOffset = 0;
            int blueGradient, greenGradient, redGradient = 0;
            double blue = 0, green = 0, red = 0;

            bool exceedsThreshold = false;

            for (int offsetY = 1; offsetY < 
                 sourceBitmap.Height - 1; offsetY++)
            {
                for (int offsetX = 1; offsetX <
                    sourceBitmap.Width - 1; offsetX++)
                {
                    byteOffset = offsetY * sourceData.Stride +
                                 offsetX * 4;

                    blueGradient = 
                    Math.Abs(pixelBuffer[byteOffset - 4] -
                    pixelBuffer[byteOffset + 4]);

                    blueGradient += 
                    Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] - 
                    pixelBuffer[byteOffset + sourceData.Stride]);
                    
                    byteOffset++;

                    greenGradient = 
                    Math.Abs(pixelBuffer[byteOffset - 4] - 
                    pixelBuffer[byteOffset + 4]);

                    greenGradient += 
                    Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] - 
                    pixelBuffer[byteOffset + sourceData.Stride]);

                    byteOffset++;

                    redGradient = 
                    Math.Abs(pixelBuffer[byteOffset - 4] - 
                    pixelBuffer[byteOffset + 4]);

                    redGradient += 
                    Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] - 
                    pixelBuffer[byteOffset + sourceData.Stride]);
                    
                    if (blueGradient + greenGradient + redGradient > threshold)
                    { exceedsThreshold = true; }
                    else
                    {
                        byteOffset -= 2;

                        blueGradient = Math.Abs(pixelBuffer[byteOffset - 4] - 
                                                pixelBuffer[byteOffset + 4]);
                        byteOffset++;

                        greenGradient = Math.Abs(pixelBuffer[byteOffset - 4] - 
                                                 pixelBuffer[byteOffset + 4]);
                        byteOffset++;

                        redGradient = Math.Abs(pixelBuffer[byteOffset - 4] - 
                                               pixelBuffer[byteOffset + 4]);

                        if (blueGradient + greenGradient + redGradient > threshold)
                        { exceedsThreshold = true; }
                        else
                        {
                            byteOffset -= 2;

                            blueGradient = 
                            Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] - 
                            pixelBuffer[byteOffset + sourceData.Stride]);

                            byteOffset++;

                            greenGradient = 
                            Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] - 
                            pixelBuffer[byteOffset + sourceData.Stride]);

                            byteOffset++;

                            redGradient = 
                            Math.Abs(pixelBuffer[byteOffset - sourceData.Stride] - 
                            pixelBuffer[byteOffset + sourceData.Stride]);

                            if (blueGradient + greenGradient + 
                                      redGradient > threshold)
                            { exceedsThreshold = true; }
                            else
                            {
                                byteOffset -= 2;

                                blueGradient = 
                                Math.Abs(pixelBuffer[byteOffset - 4 - sourceData.Stride] - 
                                pixelBuffer[byteOffset + 4 + sourceData.Stride]);

                                blueGradient += 
                                Math.Abs(pixelBuffer[byteOffset - sourceData.Stride + 4] - 
                                pixelBuffer[byteOffset + sourceData.Stride - 4]);

                                byteOffset++;

                                greenGradient = 
                                Math.Abs(pixelBuffer[byteOffset - 4 - sourceData.Stride] - 
                                pixelBuffer[byteOffset + 4 + sourceData.Stride]);

                                greenGradient += 
                                Math.Abs(pixelBuffer[byteOffset - sourceData.Stride + 4] - 
                                pixelBuffer[byteOffset + sourceData.Stride - 4]);

                                byteOffset++;

                                redGradient = 
                                Math.Abs(pixelBuffer[byteOffset - 4 - sourceData.Stride] - 
                                pixelBuffer[byteOffset + 4 + sourceData.Stride]);

                                redGradient +=
                                Math.Abs(pixelBuffer[byteOffset - sourceData.Stride + 4] - 
                                pixelBuffer[byteOffset + sourceData.Stride - 4]);

                                if (blueGradient + greenGradient + redGradient > threshold)
                                { exceedsThreshold = true; }
                                else
                                { exceedsThreshold = false; }
                            }
                        }
                    }

                    byteOffset -= 2;

                    if (exceedsThreshold)
                    {
                        blue = 0;
                        green = 0;
                        red = 0;
                    }
                    else
                    {
                        blue = pixelBuffer[byteOffset];
                        green = pixelBuffer[byteOffset + 1];
                        red = pixelBuffer[byteOffset + 2];
                    }

                    blue = (blue > 255 ? 255 :
                           (blue < 0 ? 0 :
                            blue));

                    green = (green > 255 ? 255 :
                            (green < 0 ? 0 :
                             green));

                    red = (red > 255 ? 255 :
                          (red < 0 ? 0 :
                           red)); 

                    resultBuffer[byteOffset] = (byte)blue;
                    resultBuffer[byteOffset + 1] = (byte)green;
                    resultBuffer[byteOffset + 2] = (byte)red;
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



        public static Bitmap SmoothingFilter(this Bitmap sourceBitmap,
                                    SmoothingFilterType smoothFilter =
                                    SmoothingFilterType.None)
        {
            Bitmap inputBitmap = null;

            switch (smoothFilter)
            {
                case SmoothingFilterType.None:
                    {
                        inputBitmap = sourceBitmap;
                    } break;
                case SmoothingFilterType.Gaussian3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                   Matrix.Gaussian3x3, 1.0 / 16.0, 0);
                    } break;
                case SmoothingFilterType.Gaussian5x5:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                  Matrix.Gaussian5x5, 1.0 / 159.0, 0);
                    } break;
                case SmoothingFilterType.Gaussian7x7:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                  Matrix.Gaussian7x7, 1.0 / 136.0, 0);
                    } break;
                case SmoothingFilterType.Median3x3:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(3);
                    } break;
                case SmoothingFilterType.Median5x5:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(5);
                    } break;
                case SmoothingFilterType.Median7x7:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(7);
                    } break;
                case SmoothingFilterType.Median9x9:
                    {
                        inputBitmap = sourceBitmap.MedianFilter(9);
                    } break;
                case SmoothingFilterType.Mean3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.Mean3x3, 1.0 / 9.0, 0);
                    } break;
                case SmoothingFilterType.Mean5x5:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.Mean5x5, 1.0 / 25.0, 0);
                    } break;
                case SmoothingFilterType.LowPass3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.LowPass3x3, 1.0 / 16.0, 0);
                    } break;
                case SmoothingFilterType.LowPass5x5:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.LowPass5x5, 1.0 / 60.0, 0);
                    } break;
                case SmoothingFilterType.Sharpen3x3:
                    {
                        inputBitmap = sourceBitmap.ConvolutionFilter(
                                      Matrix.Sharpen3x3, 1.0 / 8.0, 0);
                    } break;
            }

            return inputBitmap;
        }




        private static Bitmap ConvolutionFilter(this Bitmap sourceBitmap,
                                                  double[,] filterMatrix,
                                                       double factor = 1,
                                                            int bias = 0)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                 PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

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

                    blue = factor * blue + bias;
                    green = factor * green + bias;
                    red = factor * red + bias;

                    blue = (blue > 255 ? 255 :
                           (blue < 0 ? 0 :
                            blue));

                    green = (green > 255 ? 255 :
                            (green < 0 ? 0 :
                             green));

                    red = (red > 255 ? 255 :
                          (red < 0 ? 0 :
                           red)); 

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



        public enum SmoothingFilterType
        {
            None,
            Gaussian3x3,
            Gaussian5x5,
            Gaussian7x7,
            Median3x3,
            Median5x5,
            Median7x7,
            Median9x9,
            Mean3x3,
            Mean5x5,
            LowPass3x3,
            LowPass5x5,
            Sharpen3x3,
        }
    }  
}

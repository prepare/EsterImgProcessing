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

namespace ImageUnsharpMask
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

        private static Bitmap ConvolutionFilter(Bitmap sourceBitmap, 
                                             double[,] filterMatrix, 
                                                  double factor = 1, 
                                                       int bias = 0, 
                                             bool grayscale = false) 
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
                float rgb = 0;

                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;


                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth-1) / 2;
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

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

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

        private static Bitmap SubtractAddFactorImage(
                                      this Bitmap subtractFrom,
                                          Bitmap subtractValue,
                                          float factor = 1.0f)
        {
            BitmapData sourceData = 
                       subtractFrom.LockBits(new Rectangle(0, 0,
                       subtractFrom.Width, subtractFrom.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] sourceBuffer = new byte[sourceData.Stride * 
                                           sourceData.Height];

            Marshal.Copy(sourceData.Scan0, sourceBuffer, 0, 
                                        sourceBuffer.Length);

            byte[] resultBuffer = new byte[sourceData.Stride * 
                                           sourceData.Height];


            BitmapData subtractData = 
                       subtractValue.LockBits(new Rectangle(0, 0,
                       subtractValue.Width, subtractValue.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] subtractBuffer = new byte[subtractData.Stride *
                                             subtractData.Height];

            Marshal.Copy(subtractData.Scan0, subtractBuffer, 0,
                                         subtractBuffer.Length);

            subtractFrom.UnlockBits(sourceData);
            subtractValue.UnlockBits(subtractData);

            double blue = 0;
            double green = 0;
            double red = 0;

            for (int k = 0; k < resultBuffer.Length &&
                           k < subtractBuffer.Length; k += 4)
            {
                blue = sourceBuffer[k] + 
                      (sourceBuffer[k] -
                       subtractBuffer[k]) * factor;

                green = sourceBuffer[k + 1] + 
                       (sourceBuffer[k + 1] -
                        subtractBuffer[k + 1]) * factor;

                red = sourceBuffer[k + 2] + 
                     (sourceBuffer[k + 2] -
                      subtractBuffer[k + 2]) * factor;


                blue = (blue < 0 ? 0 : (blue > 255 ? 255 : blue));
                green = (green < 0 ? 0 : (green > 255 ? 255 : green));
                red = (red < 0 ? 0 : (red > 255 ? 255 : red));

                resultBuffer[k] = (byte)blue;
                resultBuffer[k + 1] = (byte)green;
                resultBuffer[k + 2] = (byte)red;
                resultBuffer[k + 3] = 255;
            }

            Bitmap resultBitmap = new Bitmap(subtractFrom.Width, 
                                             subtractFrom.Height);

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

        public static Bitmap UnsharpGaussian3x3(
                                         this Bitmap sourceBitmap, 
                                         float factor = 1.0f)
        {
            Bitmap blurBitmap = ExtBitmap.ConvolutionFilter(
                                          sourceBitmap, 
                                          Matrix.Gaussian3x3, 
                                          1.0 / 16.0);

            Bitmap resultBitmap = 
                   sourceBitmap.SubtractAddFactorImage(
                                blurBitmap, factor);

            return resultBitmap;
        }

        public static Bitmap UnsharpGaussian5x5(
                                         this Bitmap sourceBitmap,
                                         float factor = 1.0f)
        {
            Bitmap blurBitmap = ExtBitmap.ConvolutionFilter(
                                          sourceBitmap, 
                                          Matrix.Gaussian5x5Type1, 
                                          1.0 / 159.0);

            Bitmap resultBitmap =
                   sourceBitmap.SubtractAddFactorImage(
                                blurBitmap, factor);

            return resultBitmap;
        }

        public static Bitmap UnsharpMean3x3(
                                         this Bitmap sourceBitmap,
                                         float factor = 1.0f)
        {
            Bitmap blurBitmap = ExtBitmap.ConvolutionFilter(
                                          sourceBitmap, 
                                          Matrix.Mean3x3, 
                                          1.0 / 9.0);

            Bitmap resultBitmap =
                   sourceBitmap.SubtractAddFactorImage(
                                blurBitmap, factor);

            return resultBitmap;
        }

        public static Bitmap UnsharpMean5x5(
                                         this Bitmap sourceBitmap,
                                         float factor = 1.0f)
        {
            Bitmap blurBitmap = ExtBitmap.ConvolutionFilter(
                                          sourceBitmap, 
                                          Matrix.Mean5x5, 
                                          1.0 / 25.0);

            Bitmap resultBitmap =
                   sourceBitmap.SubtractAddFactorImage(
                                blurBitmap, factor);

            return resultBitmap;
        }
    }  
}

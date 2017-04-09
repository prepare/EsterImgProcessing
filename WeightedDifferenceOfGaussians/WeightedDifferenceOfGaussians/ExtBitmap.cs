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

namespace WeightedDifferenceOfGaussians
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

        public static Bitmap DifferenceOfGaussianFilter(this Bitmap sourceBitmap, 
                                                        int matrixSize, double weight1,
                                                        double weight2)
        {
            double[,] kernel1 = 
            GaussianCalculator.Calculate(matrixSize, 
            (weight1 > weight2 ? weight1 : weight2));

            double[,] kernel2 = 
            GaussianCalculator.Calculate(matrixSize, 
            (weight1 > weight2 ? weight2 : weight1));

            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                     sourceBitmap.Width, sourceBitmap.Height),
                                                       ImageLockMode.ReadOnly,
                                                 PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] grayscaleBuffer = new byte[sourceData.Width * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            double rgb = 0;

            for (int source = 0, dst = 0; 
                 source < pixelBuffer.Length && dst < grayscaleBuffer.Length; 
                 source += 4, dst++)
            {
                rgb = pixelBuffer[source] * 0.11f;
                rgb += pixelBuffer[source + 1] * 0.59f;
                rgb += pixelBuffer[source + 2] * 0.3f;

                grayscaleBuffer[dst] = (byte)rgb;
            }

            double color1 = 0.0;
            double color2 = 0.0;

            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0;

            for (int source = 0, dst = 0; 
                 source < grayscaleBuffer.Length && dst + 4 < resultBuffer.Length; 
                 source++, dst += 4)
            {
                color1 = 0;
                color2 = 0;
                
                for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                {
                    for (int filterX = -filterOffset;
                        filterX <= filterOffset; filterX++)
                    {

                        calcOffset = source + (filterX) +
                                     (filterY * sourceBitmap.Width);

                        calcOffset = (calcOffset < 0 ? 0 : 
                                     (calcOffset >= grayscaleBuffer.Length ? 
                                     grayscaleBuffer.Length - 1 : calcOffset));

                        color1 += (grayscaleBuffer[calcOffset]) *
                                   kernel1[filterY + filterOffset,
                                   filterX + filterOffset];

                        color2 += (grayscaleBuffer[calcOffset]) *
                                   kernel2[filterY + filterOffset,
                                   filterX + filterOffset];
                    }
                }

                color1 = color1 - color2;
                color1 = (color1 >= weight1 - weight2 ? 255 : 0);

                resultBuffer[dst] = (byte)color1;
                resultBuffer[dst + 1] = (byte)color1;
                resultBuffer[dst + 2] = (byte)color1;
                resultBuffer[dst + 3] = 255;
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
    }  
}

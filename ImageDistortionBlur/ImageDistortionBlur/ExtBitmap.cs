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

namespace ImageDistortionBlur
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

        public static Bitmap DistortionBlurFilter(
                 this Bitmap sourceBitmap, int distortFactor)
        {
            byte[] pixelBuffer = sourceBitmap.GetByteArray();
            byte[] resultBuffer = sourceBitmap.GetByteArray();

            int imageStride = sourceBitmap.Width * 4;
            int calcOffset = 0, filterY = 0, filterX = 0;
            int factorMax = (distortFactor + 1) * 2;
            Random rand = new Random();

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                filterY = distortFactor - rand.Next(0, factorMax);
                filterX = distortFactor - rand.Next(0, factorMax);

                if (filterX * 4 + (k % imageStride) < imageStride 
                           && filterX * 4 + (k % imageStride) > 0)
                {
                    calcOffset = k + filterY * imageStride + 
                                 4 * filterX;

                    if (calcOffset >= 0 && 
                        calcOffset + 4 < resultBuffer.Length)
                    {
                        resultBuffer[calcOffset] = pixelBuffer[k];
                        resultBuffer[calcOffset + 1] = pixelBuffer[k + 1];
                        resultBuffer[calcOffset + 2] = pixelBuffer[k + 2];
                    }
                }
            }

            return resultBuffer.GetImage(sourceBitmap.Width, 
                                sourceBitmap.Height).MedianFilter(3);
        }

        public static Bitmap MedianFilter(this Bitmap sourceBitmap,
                                          int matrixSize)
        {
            byte[] pixelBuffer = sourceBitmap.GetByteArray();
            byte[] resultBuffer = new byte[pixelBuffer.Length];
            byte[] middlePixel;

            int imageStride = sourceBitmap.Width * 4;
            int filterOffset = (matrixSize - 1) / 2;
            int calcOffset = 0, filterY = 0, filterX = 0;
            List<int> neighbourPixels = new List<int>();

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                filterY = -filterOffset; filterX = -filterOffset;
                neighbourPixels.Clear();

                while (filterY <= filterOffset)
                {
                    calcOffset = k + (filterX * 4) +
                    (filterY * imageStride);

                    if (calcOffset > 0 && 
                        calcOffset + 4 < pixelBuffer.Length)
                    {
                        neighbourPixels.Add(BitConverter.ToInt32(
                                            pixelBuffer, calcOffset));
                    }

                    filterX++;

                    if (filterX > filterOffset)
                    { filterX = -filterOffset; filterY++; }
                }

                neighbourPixels.Sort();
                middlePixel = BitConverter.GetBytes(
                              neighbourPixels[filterOffset]);

                resultBuffer[k] = middlePixel[0];
                resultBuffer[k + 1] = middlePixel[1];
                resultBuffer[k + 2] = middlePixel[2];
                resultBuffer[k + 3] = middlePixel[3];
            }

            return resultBuffer.GetImage(sourceBitmap.Width, 
                                         sourceBitmap.Height);
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

        public static Bitmap GetImage(this byte[] resultBuffer, int width, int height)
        {
            Bitmap resultBitmap = new Bitmap(width, height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                    resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static byte ClipByte(double colour)
        {
            return (byte)(colour > 255 ? 255 :
                   (colour < 0 ? 0 : colour));
        }
    }  
}

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

namespace FuzzyBlurFilter
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

        public static Bitmap FuzzyEdgeBlurFilter(this Bitmap sourceBitmap, 
                                                 int filterSize, 
                                                 float edgeFactor1, 
                                                 float edgeFactor2)
        {
            return 
            sourceBitmap.BooleanEdgeDetectionFilter(edgeFactor1).
            MeanFilter(filterSize).BooleanEdgeDetectionFilter(edgeFactor2);
        }

        public static Bitmap BooleanEdgeDetectionFilter(
               this Bitmap sourceBitmap, float edgeFactor)
        {
            byte[] pixelBuffer = sourceBitmap.GetByteArray();
            byte[] resultBuffer = new byte[pixelBuffer.Length];
            Buffer.BlockCopy(pixelBuffer, 0, resultBuffer,
                             0, pixelBuffer.Length);

            List<string> edgeMasks = GetBooleanEdgeMasks();

            int imageStride = sourceBitmap.Width * 4;
            int matrixMean = 0, pixelTotal = 0;
            int filterY = 0, filterX = 0, calcOffset = 0;
            string matrixPatern = String.Empty;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                matrixPatern = String.Empty;
                matrixMean = 0; pixelTotal = 0;
                filterY = -1; filterX = -1;

                while (filterY < 2)
                {
                    calcOffset = k + (filterX * 4) +
                    (filterY * imageStride);

                    calcOffset = (calcOffset < 0 ? 0 :
                    (calcOffset >= pixelBuffer.Length - 2 ?
                    pixelBuffer.Length - 3 : calcOffset));

                    matrixMean += pixelBuffer[calcOffset];
                    matrixMean += pixelBuffer[calcOffset + 1];
                    matrixMean += pixelBuffer[calcOffset + 2];

                    filterX += 1;

                    if (filterX > 1)
                    { filterX = -1; filterY += 1; }
                }

                matrixMean = matrixMean / 9;
                filterY = -1; filterX = -1;

                while (filterY < 2)
                {
                    calcOffset = k + (filterX * 4) +
                    (filterY * imageStride);

                    calcOffset = (calcOffset < 0 ? 0 :
                    (calcOffset >= pixelBuffer.Length - 2 ?
                    pixelBuffer.Length - 3 : calcOffset));

                    pixelTotal = pixelBuffer[calcOffset];
                    pixelTotal += pixelBuffer[calcOffset + 1];
                    pixelTotal += pixelBuffer[calcOffset + 2];

                    matrixPatern += (pixelTotal > matrixMean
                                                 ? "1" : "0");
                    filterX += 1;

                    if (filterX > 1)
                    { filterX = -1; filterY += 1; }
                }

                if (edgeMasks.Contains(matrixPatern))
                {
                    resultBuffer[k] =
                    ClipByte(resultBuffer[k] * edgeFactor);

                    resultBuffer[k + 1] =
                    ClipByte(resultBuffer[k + 1] * edgeFactor);

                    resultBuffer[k + 2] =
                    ClipByte(resultBuffer[k + 2] * edgeFactor);
                }
            }

            return resultBuffer.GetImage(sourceBitmap.Width, sourceBitmap.Height);
        }

        public static List<string> GetBooleanEdgeMasks()
        {
            List<string> edgeMasks = new List<string>();

            edgeMasks.Add("011011011");
            edgeMasks.Add("000111111");
            edgeMasks.Add("110110110");
            edgeMasks.Add("111111000");
            edgeMasks.Add("011011001");
            edgeMasks.Add("100110110");
            edgeMasks.Add("111011000");
            edgeMasks.Add("111110000");
            edgeMasks.Add("111011001");
            edgeMasks.Add("100110111");
            edgeMasks.Add("001011111");
            edgeMasks.Add("111110100");
            edgeMasks.Add("000011111");
            edgeMasks.Add("000110111");
            edgeMasks.Add("001011011");
            edgeMasks.Add("110110100");

            return edgeMasks;
        }

        private static Bitmap MeanFilter(this Bitmap sourceBitmap,
                                         int meanSize)
        {
            byte[] pixelBuffer = sourceBitmap.GetByteArray();
            byte[] resultBuffer = new byte[pixelBuffer.Length];

            double blue = 0.0, green = 0.0, red = 0.0;
            double factor = 1.0 / (meanSize * meanSize);

            int imageStride = sourceBitmap.Width * 4;
            int filterOffset = meanSize / 2;
            int calcOffset = 0, filterY = 0, filterX = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                blue = 0; green = 0; red = 0;
                filterY = -filterOffset;
                filterX = -filterOffset;

                while (filterY <= filterOffset)
                {
                    calcOffset = k + (filterX * 4) +
                    (filterY * imageStride);

                    calcOffset = (calcOffset < 0 ? 0 :
                    (calcOffset >= pixelBuffer.Length - 2 ?
                    pixelBuffer.Length - 3 : calcOffset));

                    blue += pixelBuffer[calcOffset];
                    green += pixelBuffer[calcOffset + 1];
                    red += pixelBuffer[calcOffset + 2];

                    filterX++;
                    
                    if (filterX > filterOffset)
                    {
                        filterX = -filterOffset;
                        filterY++;
                    }
                }

                resultBuffer[k] = ClipByte(factor * blue);
                resultBuffer[k + 1] = ClipByte(factor * green);
                resultBuffer[k + 2] = ClipByte(factor * red);
                resultBuffer[k + 3] = 255;
            }

            return resultBuffer.GetImage(sourceBitmap.Width, sourceBitmap.Height);
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

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
using System.Collections;

namespace SoftwareByDefault.StandardDeviationEdgeDetection
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

        public static byte[] ToPixelBuffer(this Bitmap sourceBitmap)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0,
                                       pixelBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            return pixelBuffer;
        }

        public static Bitmap ToBitmap(this byte[] resultBuffer, int width, int height)
        {
            Bitmap resultBitmap = new Bitmap(width,
                                             height, PixelFormat.Format32bppArgb);

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

        private const byte maxByteValue = Byte.MaxValue;
        private const byte minByteValue = Byte.MinValue;

        public static byte ByteVal(int val)
        {
            if (val < minByteValue) { return minByteValue; }
            else if (val > maxByteValue) { return maxByteValue; }
            else { return (byte)val; }
        }

        public static byte ByteVal(double val)
        {
            if (val < minByteValue) { return minByteValue; }
            else if (val > maxByteValue) { return maxByteValue; }
            else { return (byte)val; }
        }

        private const int pixelByteCount = 4;

        public static Bitmap StandardDeviationEdgeDetection(this Bitmap sourceBuffer, 
                                                            int filterSize, 
                                                            float varianceFactor = 1.0f, 
                                                            bool grayscaleOutput = true)
        {
            return sourceBuffer.ToPixelBuffer()
                               .StandardDeviationEdgeDetection(sourceBuffer.Width, 
                                                               sourceBuffer.Height,
                                                               filterSize,
                                                               varianceFactor,
                                                               grayscaleOutput)
                                .ToBitmap(sourceBuffer.Width, sourceBuffer.Height);
        }

        private static byte[] StandardDeviationEdgeDetection(this byte[] pixelBuffer, 
                                                             int imageWidth, 
                                                             int imageHeight,
                                                             int filterSize,
                                                             float varianceFactor = 1.0f,
                                                             bool grayscaleOutput = true)
        {
            byte[] resultBuffer = new byte[pixelBuffer.Length];

            int filterOffset = (filterSize - 1) / 2;
            int calcOffset = 0;
            int stride = imageWidth * pixelByteCount;
            
            int byteOffset = 0;
            var neighbourCount = filterSize * filterSize;
            
            var blueNeighbours = new int[neighbourCount];
            var greenNeighbours = new int[neighbourCount];
            var redNeighbours = new int[neighbourCount];

            double resetValue = 0;
            double meanBlue = 0, meanGreen = 0, meanRed = 0;
            double varianceBlue = 0, varianceGreen = 0, varianceRed = 0;

            varianceFactor = varianceFactor * varianceFactor;

            for (int offsetY = filterOffset; offsetY <
                imageHeight - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    imageWidth - filterOffset; offsetX++)
                {
                    byteOffset = offsetY *
                                 stride +
                                 offsetX * pixelByteCount;

                    meanBlue = resetValue;
                    meanGreen = resetValue;
                    meanRed = resetValue;

                    varianceBlue = resetValue;
                    varianceGreen = resetValue;
                    varianceRed = resetValue;

                    for (int filterY = -filterOffset, neighbour = 0;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++, neighbour++)
                        {
                            calcOffset = byteOffset +
                                         (filterX * pixelByteCount) +
                                         (filterY * stride);

                            blueNeighbours[neighbour] = pixelBuffer[calcOffset];
                            greenNeighbours[neighbour] = pixelBuffer[calcOffset + 1];
                            redNeighbours[neighbour] = pixelBuffer[calcOffset + 2];
                        }
                    }

                    meanBlue = blueNeighbours.Average();
                    meanGreen = greenNeighbours.Average();
                    meanRed = redNeighbours.Average();

                    for (int n = 0; n < neighbourCount; n++)
                    {
                        varianceBlue = varianceBlue + 
                                       SquareNumber(blueNeighbours[n] - meanBlue);
                        varianceGreen = varianceGreen + 
                                        SquareNumber(greenNeighbours[n] - meanGreen);
                        varianceRed = varianceRed + 
                                      SquareNumber(redNeighbours[n] - meanRed);
                    }

                    varianceBlue = varianceBlue / 
                                   neighbourCount * 
                                   varianceFactor;

                    varianceGreen = varianceGreen /
                                    neighbourCount * 
                                    varianceFactor;

                    varianceRed = varianceRed / 
                                  neighbourCount * 
                                  varianceFactor;

                    if (grayscaleOutput)
                    {
                        var pixelValue = ByteVal(ByteVal(Math.Sqrt(varianceBlue)) |
                                                 ByteVal(Math.Sqrt(varianceGreen)) | 
                                                 ByteVal(Math.Sqrt(varianceRed)));

                        resultBuffer[byteOffset] = pixelValue;
                        resultBuffer[byteOffset + 1] = pixelValue;
                        resultBuffer[byteOffset + 2] = pixelValue;
                        resultBuffer[byteOffset + 3] = Byte.MaxValue;
                    }
                    else
                    {
                        resultBuffer[byteOffset] = ByteVal(Math.Sqrt(varianceBlue));
                        resultBuffer[byteOffset + 1] = ByteVal(Math.Sqrt(varianceGreen));
                        resultBuffer[byteOffset + 2] = ByteVal(Math.Sqrt(varianceRed));
                        resultBuffer[byteOffset + 3] = Byte.MaxValue;
                    }
                }
            }

            return resultBuffer;
        }

        private static double SquareNumber(double val)
        {
            return val * val;
        }
    }
}
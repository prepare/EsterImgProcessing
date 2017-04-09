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

namespace ImageBoundaryExtraction
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

        public static Bitmap BoundaryExtractionFilter(this Bitmap sourceBitmap,
                                                      bool[,] se,
                                                      BoundaryExtractionFilterType 
                                                      filterType,
                                                      bool applyBlue = true,
                                                      bool applyGreen = true,
                                                      bool applyRed = true)
        {
            Bitmap resultBitmap = null;

            if (filterType == BoundaryExtractionFilterType.BoundaryExtraction)
            {
                resultBitmap = 
                sourceBitmap.BoundaryExtraction(se, applyBlue,
                                                applyGreen, applyRed);
            }
            else if (filterType == BoundaryExtractionFilterType.BoundarySharpen)
            {
                resultBitmap = 
                sourceBitmap.BoundarySharpen(se, applyBlue, 
                                             applyGreen, applyRed);
            }
            else if (filterType == BoundaryExtractionFilterType.BoundaryTrace)
            {
                resultBitmap = 
                sourceBitmap.BoundaryTrace(se, applyBlue, 
                                           applyGreen, applyRed);
            }

            return resultBitmap;
        }

        private static Bitmap BoundaryExtraction(this Bitmap sourceBitmap,
                                                 bool[,] se,
                                                 bool applyBlue = true,
                                                 bool applyGreen = true,
                                                 bool applyRed = true)
        {
            Bitmap resultBitmap = sourceBitmap.MorphologyOperation(se, 
                                  MorphologyOperationType.Dilation, applyBlue, 
                                                                    applyGreen, 
                                                                    applyRed);

            resultBitmap = resultBitmap.SubtractImage(sourceBitmap);

            return resultBitmap;
        }

        private static Bitmap BoundarySharpen(this Bitmap sourceBitmap,
                                              bool[,] se,
                                              bool applyBlue = true,
                                              bool applyGreen = true,
                                              bool applyRed = true)
        {
            Bitmap resultBitmap = sourceBitmap.BoundaryExtraction(se, applyBlue,
                                                                      applyGreen, 
                                                                      applyRed);

            resultBitmap = sourceBitmap.MorphologyOperation(se, 
                           MorphologyOperationType.Dilation, applyBlue, 
                                                             applyGreen, 
                                                applyRed).AddImage(resultBitmap);

            return resultBitmap;
        }

        private static Bitmap BoundaryTrace(this Bitmap sourceBitmap,
                                            bool[,] se,
                                            bool applyBlue = true,
                                            bool applyGreen = true,
                                            bool applyRed = true)
        {
            Bitmap resultBitmap = sourceBitmap.BoundaryExtraction(se, applyBlue, 
                                                                      applyGreen, 
                                                                      applyRed);

            resultBitmap = sourceBitmap.SubtractImage(resultBitmap);

            return resultBitmap;
        }

        private static Bitmap MorphologyOperation(this Bitmap sourceBitmap, 
                                                  bool[,] se,
                                                  MorphologyOperationType morphType,
                                                  bool applyBlue = true,
                                                  bool applyGreen = true,
                                                  bool applyRed = true ) 
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

            int filterOffset = (se.GetLength(0) - 1) / 2;
            int calcOffset = 0, byteOffset = 0;
            byte blueErode = 0, greenErode = 0, redErode = 0;
            byte blueDilate = 0, greenDilate = 0, redDilate = 0;

            for (int offsetY = 0; offsetY < 
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = 0; offsetX < 
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY * sourceData.Stride + 
                                 offsetX * 4;

                    blueErode = 255; greenErode = 255; redErode = 255;
                    blueDilate = 0; greenDilate = 0; redDilate = 0;

                    for (int filterY = -filterOffset;
                            filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            if (se[filterY + filterOffset, 
                                   filterX + filterOffset] == true)
                            {
                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                (filterY * sourceData.Stride);

                                calcOffset = (calcOffset < 0 ? 0 : 
                                (calcOffset >= pixelBuffer.Length + 2 ? 
                                pixelBuffer.Length - 3 : calcOffset));

                                blueDilate = 
                                (pixelBuffer[calcOffset] > blueDilate ? 
                                pixelBuffer[calcOffset] : blueDilate);

                                greenDilate = 
                                (pixelBuffer[calcOffset + 1] > greenDilate ? 
                                pixelBuffer[calcOffset + 1] : greenDilate);

                                redDilate = 
                                (pixelBuffer[calcOffset + 2] > redDilate ?
                                pixelBuffer[calcOffset + 2] : redDilate);

                                blueErode = 
                                (pixelBuffer[calcOffset] < blueErode ? 
                                pixelBuffer[calcOffset] : blueErode);

                                greenErode = 
                                (pixelBuffer[calcOffset + 1] < greenErode ? 
                                pixelBuffer[calcOffset + 1] : greenErode);

                                redErode = 
                                (pixelBuffer[calcOffset + 2] < redErode ? 
                                pixelBuffer[calcOffset + 2] : redErode);
                            }
                        }
                    }

                    blueErode = (applyBlue ? blueErode : pixelBuffer[byteOffset]);
                    blueDilate = (applyBlue ? blueDilate : pixelBuffer[byteOffset]);

                    greenErode = (applyGreen ? greenErode : pixelBuffer[byteOffset + 1]);
                    greenDilate = (applyGreen ? greenDilate : pixelBuffer[byteOffset + 1]);

                    redErode = (applyRed ? redErode : pixelBuffer[byteOffset + 2]);
                    redDilate = (applyRed ? redDilate : pixelBuffer[byteOffset + 2]);

                    if (morphType == MorphologyOperationType.Erosion)
                    {
                        resultBuffer[byteOffset] = blueErode;
                        resultBuffer[byteOffset + 1] = greenErode;
                        resultBuffer[byteOffset + 2] = redErode;
                    }
                    else if (morphType == MorphologyOperationType.Dilation)
                    {
                        resultBuffer[byteOffset] = blueDilate;
                        resultBuffer[byteOffset + 1] = greenDilate;
                        resultBuffer[byteOffset + 2] = redDilate;
                    }

                    resultBuffer[byteOffset + 3] = 255;
                }
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                    resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly,
                                    PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, 
                                       resultBuffer.Length);

            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static Bitmap SubtractImage(this Bitmap sourceBitmap, 
                                                 Bitmap subtractBitmap)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] resultBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            Marshal.Copy(sourceData.Scan0, resultBuffer, 0,
                                       resultBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            BitmapData subtractData =
                       subtractBitmap.LockBits(new Rectangle(0, 0,
                       subtractBitmap.Width, subtractBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] subtractBuffer = new byte[subtractData.Stride *
                                          subtractData.Height];

            Marshal.Copy(subtractData.Scan0, subtractBuffer, 0,
                                       subtractBuffer.Length);

            subtractBitmap.UnlockBits(subtractData);

            for (int k = 0; k + 4 < resultBuffer.Length && 
                            k + 4 < subtractBuffer.Length; k += 4)
            {
                resultBuffer[k] = 
                SubtractColors(resultBuffer[k], subtractBuffer[k]);

                resultBuffer[k + 1] = 
                SubtractColors(resultBuffer[k + 1], subtractBuffer[k + 1]);

                resultBuffer[k + 2] =
                SubtractColors(resultBuffer[k + 2], subtractBuffer[k + 2]);

                resultBuffer[k + 3] = 255;
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

        private static Bitmap AddImage(this Bitmap sourceBitmap, Bitmap addBitmap)
        {
            BitmapData sourceData =
                       sourceBitmap.LockBits(new Rectangle(0, 0,
                       sourceBitmap.Width, sourceBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] resultBuffer = new byte[sourceData.Stride *
                                          sourceData.Height];

            Marshal.Copy(sourceData.Scan0, resultBuffer, 0,
                                       resultBuffer.Length);

            sourceBitmap.UnlockBits(sourceData);

            BitmapData addData =
                       addBitmap.LockBits(new Rectangle(0, 0,
                       addBitmap.Width, addBitmap.Height),
                       ImageLockMode.ReadOnly,
                       PixelFormat.Format32bppArgb);

            byte[] addBuffer = new byte[addData.Stride *
                                          addData.Height];

            Marshal.Copy(addData.Scan0, addBuffer, 0,
                                       addBuffer.Length);

            addBitmap.UnlockBits(addData);

            for (int k = 0; k + 4 < resultBuffer.Length && 
                            k + 4 < addBuffer.Length; k += 4)
            {
                resultBuffer[k] = 
                AddColors(resultBuffer[k], addBuffer[k]);

                resultBuffer[k + 1] = 
                AddColors(resultBuffer[k + 1], addBuffer[k + 1]);

                resultBuffer[k + 2] = 
                AddColors(resultBuffer[k + 2], addBuffer[k + 2]);

                resultBuffer[k + 3] = 255;
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

        private static byte SubtractColors(byte color1, byte color2)
        {
            int result = (int)color1 - (int)color2;

            return (byte)(result < 0 ? 0 : result);
        }

        private static byte AddColors(byte color1, byte color2)
        {
            int result = color1 + color2;

            return (byte)(result < 0 ? 0 : (result > 255 ? 255 : result));
        }

        private enum MorphologyOperationType
        {
            Dilation,
            Erosion,
        }

        public enum BoundaryExtractionFilterType
        {
            BoundaryExtraction,
            BoundarySharpen,
            BoundaryTrace
        }
    }  
}

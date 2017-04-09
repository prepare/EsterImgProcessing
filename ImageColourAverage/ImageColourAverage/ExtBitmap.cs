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

namespace ImageColourAverage
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

        public static Bitmap AverageColoursFilter(this Bitmap sourceBitmap, 
                                                int matrixSize,  
                                                bool applyBlue = true,
                                                bool applyGreen = true,
                                                bool applyRed = true,
                                                ColorShiftType shiftType =
                                                ColorShiftType.None) 
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

            int blue = 0;
            int green = 0;
            int red = 0;

            List<int> sortList = new List<int>();

            for (int offsetY = filterOffset; offsetY < 
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < 
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    byteOffset = offsetY * 
                                 sourceData.Stride + 
                                 offsetX * 4;

                    blue = 0;
                    green = 0;
                    red = 0;

                    for (int filterY = -filterOffset; 
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {

                            calcOffset = byteOffset + 
                                         (filterX * 4) + 
                                         (filterY * sourceData.Stride);

                            blue += pixelBuffer[calcOffset];
                            green += pixelBuffer[calcOffset + 1];
                            red += pixelBuffer[calcOffset + 2];
                        }
                    }

                    blue = blue / matrixSize;
                    green = green / matrixSize;
                    red = red / matrixSize;

                    if (applyBlue == false)
                    {
                        blue = pixelBuffer[byteOffset];
                    }

                    if (applyGreen == false)
                    {
                        green = pixelBuffer[byteOffset + 1];
                    }

                    if (applyRed == false)
                    {
                        red = pixelBuffer[byteOffset + 2];
                    }

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

        public enum ColorShiftType
        {
            None,
            ShiftLeft,
            ShiftRight
        }
    }  
}

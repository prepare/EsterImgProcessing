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

namespace BitmapShading
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

        public static Bitmap BitwiseBlend(this Bitmap sourceBitmap, Bitmap blendBitmap, 
                                          BitwiseBlendType blendTypeBlue, BitwiseBlendType 
                                          blendTypeGreen, BitwiseBlendType blendTypeRed)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                    sourceBitmap.Width, sourceBitmap.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            BitmapData blendData = blendBitmap.LockBits(new Rectangle(0, 0,
                                    blendBitmap.Width, blendBitmap.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] blendBuffer = new byte[blendData.Stride * blendData.Height];
            Marshal.Copy(blendData.Scan0, blendBuffer, 0, blendBuffer.Length);
            blendBitmap.UnlockBits(blendData);

            int blue = 0, green = 0, red = 0;

            for (int k = 0; (k + 4 < pixelBuffer.Length) && 
                            (k + 4 < blendBuffer.Length); k += 4)
            {
                if (blendTypeBlue == BitwiseBlendType.And)
                {
                    blue = pixelBuffer[k] & blendBuffer[k];
                }
                else if (blendTypeBlue == BitwiseBlendType.Or)
                {
                    blue = pixelBuffer[k] | blendBuffer[k];
                }
                else if (blendTypeBlue == BitwiseBlendType.Xor)
                {
                    blue = pixelBuffer[k] ^ blendBuffer[k];
                }

                if (blendTypeGreen == BitwiseBlendType.And)
                {
                    green = pixelBuffer[k+1] & blendBuffer[k+1];
                }
                else if (blendTypeGreen == BitwiseBlendType.Or)
                {
                    green = pixelBuffer[k+1] | blendBuffer[k+1];
                }
                else if (blendTypeGreen == BitwiseBlendType.Xor)
                {
                    green = pixelBuffer[k+1] ^ blendBuffer[k+1];
                }

                if (blendTypeRed == BitwiseBlendType.And)
                {
                    red = pixelBuffer[k+2] & blendBuffer[k+2];
                }
                else if (blendTypeRed == BitwiseBlendType.Or)
                {
                    red = pixelBuffer[k+2] | blendBuffer[k+2];
                }
                else if (blendTypeRed == BitwiseBlendType.Xor)
                {
                    red = pixelBuffer[k+2] ^ blendBuffer[k+2];
                }

                if (blue < 0)
                { blue = 0; }
                else if (blue > 255)
                { blue = 255; }

                if (green < 0)
                { green = 0; }
                else if (green > 255)
                { green = 255; }

                if (red < 0)
                { red = 0; }
                else if (red > 255)
                { red = 255; }

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                    resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public enum BitwiseBlendType
        {
            None,
            Or,
            And,
            Xor
        }
    }
}

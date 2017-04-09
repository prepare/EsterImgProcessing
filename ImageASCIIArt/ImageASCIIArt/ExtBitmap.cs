/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace ImageASCIIArt
{
    public static class ExtBitmap
    {
        public static string ASCIIFilter(this Bitmap sourceBitmap, int pixelBlockSize, 
                                                                   int colorCount = 0)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                    sourceBitmap.Width, sourceBitmap.Height),
                                                      ImageLockMode.ReadOnly,
                                                PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);

            StringBuilder asciiArt = new StringBuilder();

            int avgBlue = 0;
            int avgGreen = 0;
            int avgRed = 0;
            int offset = 0;

            int rows = sourceBitmap.Height / pixelBlockSize;
            int columns = sourceBitmap.Width / pixelBlockSize;

            if (colorCount > 0)
            {
                colorCharacters = GenerateRandomString(colorCount);
            }

            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++)
                {
                    avgBlue = 0;
                    avgGreen = 0;
                    avgRed = 0;

                    for (int pY = 0; pY < pixelBlockSize; pY++)
                    {
                        for (int pX = 0; pX < pixelBlockSize; pX++)
                        {
                            offset = y * pixelBlockSize * sourceData.Stride + 
                                     x * pixelBlockSize * 4;

                            offset += pY * sourceData.Stride;
                            offset += pX * 4;

                            avgBlue += pixelBuffer[offset];
                            avgGreen += pixelBuffer[offset + 1];
                            avgRed += pixelBuffer[offset + 2];
                        }
                    }

                    avgBlue = avgBlue / (pixelBlockSize * pixelBlockSize);
                    avgGreen = avgGreen / (pixelBlockSize * pixelBlockSize);
                    avgRed = avgRed / (pixelBlockSize * pixelBlockSize);

                    asciiArt.Append(GetColorCharacter(avgBlue, avgGreen, avgRed));
                }

                asciiArt.Append("\r\n");
            }

            return asciiArt.ToString();
        }

        private static string GenerateRandomString(int maxSize)
        {
            StringBuilder stringBuilder = new StringBuilder(maxSize);
            Random randomChar = new Random();

            char charValue;

            for (int k = 0; k < maxSize; k++)
            {
                charValue = (char)(Math.Floor(255 * randomChar.NextDouble() * 4));

                if (stringBuilder.ToString().IndexOf(charValue) != -1)
                {
                    charValue = (char)(Math.Floor((byte)charValue * 
                                            randomChar.NextDouble()));
                }

                if (Char.IsControl(charValue) == false && 
                    Char.IsPunctuation(charValue) == false && 
                    stringBuilder.ToString().IndexOf(charValue) == -1)
                {
                    stringBuilder.Append(charValue);

                    randomChar = new Random((int)((byte)charValue * 
                                     (k + 1) + DateTime.Now.Ticks));
                }
                else
                {
                    randomChar = new Random((int)((byte)charValue * 
                                     (k + 1) + DateTime.UtcNow.Ticks));
                    k -= 1;
                }
            }

            return stringBuilder.ToString().RandomStringSort();
        }

        public static string RandomStringSort(this string stringValue)
        {
            char[] charArray = stringValue.ToCharArray();

            Random randomIndex = new Random((byte)charArray[0]);
            int iterator = charArray.Length;

            while (iterator > 1)
            {
                iterator -= 1;

                int nextIndex = randomIndex.Next(iterator + 1);

                char nextValue = charArray[nextIndex];
                charArray[nextIndex] = charArray[iterator];
                charArray[iterator] = nextValue;
            }

            return new string(charArray);
        }

        private static string colorCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static string GetColorCharacter(int blue, int green, int red)
        {
            string colorChar = String.Empty;
            int intensity = (blue + green + red) / 3 * 
                            (colorCharacters.Length - 1) / 255;

            colorChar = colorCharacters.Substring(intensity, 1).ToUpper();
            colorChar += colorChar.ToLower();

            return colorChar;
        }

        public static Bitmap TextToImage(this string text, Font font, 
                                                        float factor)
        {
            Bitmap textBitmap = new Bitmap(1, 1);

            Graphics graphics = Graphics.FromImage(textBitmap);

            int width = (int)Math.Ceiling(
                        graphics.MeasureString(text, font).Width * 
                        factor);

            int height = (int)Math.Ceiling(
                         graphics.MeasureString(text, font).Height * 
                         factor);

            graphics.Dispose();

            textBitmap = new Bitmap(width, height, 
                                    PixelFormat.Format32bppArgb);

            graphics = Graphics.FromImage(textBitmap);
            graphics.Clear(Color.Black);

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            graphics.ScaleTransform(factor, factor);
            graphics.DrawString(text, font, Brushes.White, new PointF(0, 0));

            graphics.Flush();
            graphics.Dispose();

            return textBitmap;
        }

        public static Bitmap ScaleBitmap(this Bitmap sourceBitmap, float factor)
        {
            Bitmap resultBitmap = new Bitmap((int)(sourceBitmap.Width * factor), 
                                             (int)(sourceBitmap.Height * factor), 
                                             PixelFormat.Format32bppArgb);

            Graphics graphics = Graphics.FromImage(resultBitmap);

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            graphics.DrawImage(sourceBitmap, 
                new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), 
                new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), 
                                                         GraphicsUnit.Pixel);

            return resultBitmap;
        }
    }  
}

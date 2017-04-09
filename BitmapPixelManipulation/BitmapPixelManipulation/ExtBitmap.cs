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
using System.IO;
using System.Collections;

namespace BitmapPixelManipulation
{
    public static class ExtBitmap
    {
        public static Bitmap FlipPixels(this Bitmap sourceImage)
        {
            List<ArgbPixel> pixelList = GetPixelListFromBitmap(sourceImage);

            pixelList.Reverse();

            Bitmap resultBitmap = GetBitmapFromPixelList(pixelList, 
                                sourceImage.Width, sourceImage.Height);

            return resultBitmap;
        }

        public static Bitmap SwapColors(this Bitmap sourceImage, 
                                        ColourSwapType swapType, 
                                        byte fixedValue = 0)
        {
            List<ArgbPixel> pixelListSource = GetPixelListFromBitmap(sourceImage);

            List<ArgbPixel> pixelListResult = null;

            switch (swapType)
            {
                case ColourSwapType.ShiftRight:
                    {
                        pixelListResult = (from t in pixelListSource 
                                           select new ArgbPixel 
                        { blue = t.red, 
                          red = t.green, 
                          green = t.blue, 
                          alpha = t.alpha }).ToList();
                        break;
                    }
                case ColourSwapType.ShiftLeft:
                    {
                        pixelListResult = (from t in pixelListSource 
                                           select new ArgbPixel 
                        { blue = t.green, 
                           red = t.blue, 
                           green = t.red, 
                           alpha = t.alpha }).ToList();                        
                        break;
                    }
                case ColourSwapType.SwapBlueAndRed:
                    {
                        pixelListResult = (from t in pixelListSource
                                           select new ArgbPixel 
                        { blue = t.red, 
                          red = t.blue, 
                          green = t.green, 
                          alpha = t.alpha }).ToList();
                        break;
                    }
                case ColourSwapType.SwapBlueAndRedFixGreen:
                    {
                        pixelListResult = (from t in pixelListSource 
                                           select new ArgbPixel 
                        { blue = t.red, 
                          red = t.blue, 
                          green = fixedValue, 
                          alpha = t.alpha }).ToList();
                        break;
                    }
                case ColourSwapType.SwapBlueAndGreen:
                    {
                        pixelListResult = (from t in pixelListSource 
                                           select new ArgbPixel 
                        { blue = t.green, 
                          red = t.red, 
                          green = t.blue, 
                          alpha = t.alpha }).ToList();                        
                        break;
                    }
                case ColourSwapType.SwapBlueAndGreenFixRed:
                    {
                        pixelListResult = (from t in pixelListSource 
                                           select new ArgbPixel 
                        { blue = t.green, 
                          red = fixedValue,
                          green = t.blue, 
                          alpha = t.alpha }).ToList();
                        break;
                    }
                case ColourSwapType.SwapRedAndGreen:
                    {
                        pixelListResult = (from t in pixelListSource 
                                           select new ArgbPixel 
                        { blue = t.blue, 
                          red = t.green, 
                          green = t.red, 
                          alpha = t.alpha }).ToList();
                        break;
                    }
                case ColourSwapType.SwapRedAndGreenFixBlue:
                    {
                        pixelListResult = (from t in pixelListSource 
                                           select new ArgbPixel 
                        { blue = fixedValue, 
                          red = t.green, 
                          green = t.red, 
                          alpha = t.alpha }).ToList();
                        break;
                    }
            }

            Bitmap resultBitmap = GetBitmapFromPixelList(pixelListResult, 
                                  sourceImage.Width, sourceImage.Height);

            return resultBitmap;
        }

        private static Bitmap GetBitmapFromPixelList(List<ArgbPixel> pixelList, int width, int height)
        {
            Bitmap resultBitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0, 
                        resultBitmap.Width, resultBitmap.Height), 
                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] resultBuffer = new byte[resultData.Stride * resultData.Height];

            using (MemoryStream memoryStream = new MemoryStream(resultBuffer))
            {
                memoryStream.Position = 0;
                BinaryWriter binaryWriter = new BinaryWriter(memoryStream);

                foreach (ArgbPixel pixel in pixelList)
                {
                    binaryWriter.Write(pixel.GetColorBytes());
                }

                binaryWriter.Close();
            }

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        private static List<ArgbPixel> GetPixelListFromBitmap(Bitmap sourceImage)
        {
            BitmapData sourceData = sourceImage.LockBits(new Rectangle(0, 0, 
                        sourceImage.Width, sourceImage.Height), 
                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] sourceBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, sourceBuffer, 0, sourceBuffer.Length);
            sourceImage.UnlockBits(sourceData);

            List<ArgbPixel> pixelList = new List<ArgbPixel>(sourceBuffer.Length / 4);

            using (MemoryStream memoryStream = new MemoryStream(sourceBuffer))
            {
                memoryStream.Position = 0;
                BinaryReader binaryReader = new BinaryReader(memoryStream);

                while (memoryStream.Position + 4 <= memoryStream.Length)
                {
                    ArgbPixel pixel = new ArgbPixel(binaryReader.ReadBytes(4));
                    pixelList.Add(pixel);
                }

                binaryReader.Close();
            }

            return pixelList;
        }

        public class ArgbPixel
        {
            public byte blue = 0;
            public byte green = 0;
            public byte red = 0;
            public byte alpha = 0;

            public ArgbPixel()
            {

            }

            public ArgbPixel(byte[] colorComponents)
            {
                blue = colorComponents[0];
                green = colorComponents[1];
                red = colorComponents[2];
                alpha = colorComponents[3];
            }

            public byte[] GetColorBytes()
            {
                return new byte[] {blue, green, red, alpha};
            }
        }
    }

    public enum ColourSwapType
    {
        ShiftRight,
        ShiftLeft,
        SwapBlueAndRed,
        SwapBlueAndRedFixGreen,
        SwapBlueAndGreen,
        SwapBlueAndGreenFixRed,
        SwapRedAndGreen,
        SwapRedAndGreenFixBlue
    }
}

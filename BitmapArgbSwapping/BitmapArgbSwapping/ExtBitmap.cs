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

namespace BitmapArgbSwapping
{
    public static class ExtBitmap
    {
        public static Bitmap SwapColorsCopy(this Bitmap originalImage, ColorSwapFilter swapFilterData)
        {
            BitmapData sourceData = originalImage.LockBits
                                    (new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                                    ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, resultBuffer, 0, resultBuffer.Length);
            originalImage.UnlockBits(sourceData);

            byte sourceBlue = 0, resultBlue = 0, 
                 sourceGreen = 0, resultGreen = 0, 
                 sourceRed = 0, resultRed = 0;
            byte byte2 = 2, maxValue = 255;

            for (int k = 0; k < resultBuffer.Length; k += 4)
            {
                sourceBlue = resultBuffer[k];
                sourceGreen = resultBuffer[k + 1];
                sourceRed = resultBuffer[k + 2];

                if (swapFilterData.InvertColorsWhenSwapping == true)
                {
                    sourceBlue = (byte)(maxValue - sourceBlue);
                    sourceGreen = (byte)(maxValue - sourceGreen);
                    sourceRed = (byte)(maxValue - sourceRed);
                }

                if (swapFilterData.SwapHalfColorValues == true)
                {
                    sourceBlue = (byte)(sourceBlue / byte2);
                    sourceGreen = (byte)(sourceGreen / byte2);
                    sourceRed = (byte)(sourceRed / byte2);
                }

                switch (swapFilterData.SwapType)
                {
                    case ColorSwapFilter.ColorSwapType.ShiftRight:
                        {
                            resultBlue = sourceGreen;
                            resultRed = sourceBlue;
                            resultGreen = sourceRed;
                            
                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.ShiftLeft:
                        {
                            resultBlue = sourceRed;
                            resultRed = sourceGreen;
                            resultGreen = sourceBlue;
                            
                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.SwapBlueAndRed:
                        {
                            resultBlue = sourceRed;
                            resultRed = sourceBlue;

                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.SwapBlueAndGreen:
                        {
                            resultBlue = sourceGreen;
                            resultGreen = sourceBlue;

                            break;
                        }
                    case ColorSwapFilter.ColorSwapType.SwapRedAndGreen:
                        {
                            resultRed = sourceGreen;
                            resultGreen = sourceGreen;

                            break;
                        }
                }

                resultBuffer[k] = resultBlue;
                resultBuffer[k + 1] = resultGreen;
                resultBuffer[k + 2] = resultRed;
            }

            Bitmap resultBitmap = new Bitmap(originalImage.Width, originalImage.Height, 
                                             PixelFormat.Format32bppArgb);

            BitmapData resultData = resultBitmap.LockBits
                                    (new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height),
                                    ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }
    }

    public class ColorSwapFilter
    {
        private ColorSwapType swapType = ColorSwapType.ShiftRight;
        public ColorSwapType SwapType
        {
            get { return swapType; }
            set { swapType = value; }
        }

        private bool swapHalfColorValues = false;
        public bool SwapHalfColorValues
        {
            get { return swapHalfColorValues; }
            set { swapHalfColorValues = value; }
        }

        private bool invertColorsWhenSwapping = false;
        public bool InvertColorsWhenSwapping
        {
            get { return invertColorsWhenSwapping; }
            set { invertColorsWhenSwapping = value; }
        }
        
        public enum ColorSwapType
        {
            ShiftRight,
            ShiftLeft,
            SwapBlueAndRed,
            SwapBlueAndGreen,
            SwapRedAndGreen,
        }
    }
}

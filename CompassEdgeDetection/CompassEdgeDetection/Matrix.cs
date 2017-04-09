/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompassEdgeDetection
{
    public static class Matrix
    {
        public static double[, ,] RotateMatrix(double[,] baseKernel, 
                                                     double degrees)
        {
            double[, ,] kernel = new double[(int)(360 / degrees), 
               baseKernel.GetLength(0), baseKernel.GetLength(1)];

            int xOffset = baseKernel.GetLength(1) / 2;
            int yOffset = baseKernel.GetLength(0) / 2;

            for (int y = 0; y < baseKernel.GetLength(0); y++)
            {
                for (int x = 0; x < baseKernel.GetLength(1); x++)
                {
                    for (int compass = 0; compass < 
                        kernel.GetLength(0); compass++)
                    {
                        double radians = compass * degrees *
                                         Math.PI / 180.0;

                        int resultX = (int)(Math.Round((x - xOffset) *
                                   Math.Cos(radians) - (y - yOffset) *
                                   Math.Sin(radians)) + xOffset);

                        int resultY = (int)(Math.Round((x - xOffset) *
                                   Math.Sin(radians) + (y - yOffset) *
                                   Math.Cos(radians)) + yOffset);

                        kernel[compass, resultY, resultX] =
                                                    baseKernel[y, x];
                    }
                }
            }

            return kernel;
        }

        public static double[, ,] Prewitt3x3x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -1,  0,  1, }, 
                  { -1,  0,  1, }, 
                  { -1,  0,  1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Prewitt3x3x8
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -1,  0,  1, }, 
                  { -1,  0,  1, }, 
                  { -1,  0,  1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 45);


                return kernel;
            }
        }

        public static double[, ,] Prewitt5x5x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -2, -1,  0,  1, 2, }, 
                  { -2, -1,  0,  1, 2, },
                  { -2, -1,  0,  1, 2, },
                  { -2, -1,  0,  1, 2, }, 
                  { -2, -1,  0,  1, 2, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Kirsch3x3x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -3, -3,  5, }, 
                  { -3,  0,  5, }, 
                  { -3, -3,  5, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Kirsch3x3x8
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -3, -3,  5, }, 
                  { -3,  0,  5, }, 
                  { -3, -3,  5, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 45);


                return kernel;
            }
        }

        public static double[, ,] Sobel3x3x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -1,  0,  1, }, 
                  { -2,  0,  2, }, 
                  { -1,  0,  1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Sobel3x3x8
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -1,  0,  1, }, 
                  { -2,  0,  2, }, 
                  { -1,  0,  1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 45);


                return kernel;
            }
        }

        public static double[, ,] Sobel5x5x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { {  -5,  -4,  0,   4,  5, }, 
                  {  -8, -10,  0,  10,  8, },
                  { -10, -20,  0,  20, 10, },
                  {  -8, -10,  0,  10,  8, }, 
                  {  -5,  -4,  0,   4,  5, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Scharr3x3x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -1,  0,  1, }, 
                  { -3,  0,  3, }, 
                  { -1,  0,  1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Scharr3x3x8
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { { -1,  0,  1, }, 
                  { -3,  0,  3, }, 
                  { -1,  0,  1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 45);


                return kernel;
            }
        }

        public static double[, ,] Scharr5x5x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { {  -1,  -1,  0,   1,  1, }, 
                  {  -2,  -2,  0,   2,  2, },
                  {  -3,  -6,  0,   6,  3, },
                  {  -2,  -2,  0,   2,  2, }, 
                  {  -1,  -1,  0,   1,  1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Isotropic3x3x4
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { {            -1,  0,             1, }, 
                  { -Math.Sqrt(2),  0,  Math.Sqrt(2), }, 
                  {            -1,  0,             1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 90);


                return kernel;
            }
        }

        public static double[, ,] Isotropic3x3x8
        {
            get
            {
                double[,] baseKernel = new double[,] 
                { {            -1,  0,             1, }, 
                  { -Math.Sqrt(2),  0,  Math.Sqrt(2), }, 
                  {            -1,  0,             1, }, };

                double[, ,] kernel = RotateMatrix(baseKernel, 45);


                return kernel;
            }
        }
    }
}

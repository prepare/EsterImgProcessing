/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpenEdgeDetection
{
    public static class Matrix
    {
        public static double[,] Sharpen7To1
        {
            get
            {
                return new double[,]  
                { { 1,  1,  1, }, 
                  { 1, -7,  1, },  
                  { 1,  1,  1, }, };
            }
        }

        public static double[,] Sharpen9To1
        {
            get
            {
                return new double[,]  
                { { -1, -1, -1, }, 
                  { -1,  9, -1, },  
                  { -1, -1, -1, }, };
            }
        }

        public static double[,] Sharpen12To1
        {
            get
            {
                return new double[,]  
                { { -1, -1, -1, }, 
                  { -1, 12, -1, },  
                  { -1, -1, -1, }, };
            }
        }

        public static double[,] Sharpen24To1
        {
            get
            {
                return new double[,]  
                { { -1, -1, -1, -1, -1, }, 
                  { -1, -1, -1, -1, -1, }, 
                  { -1, -1, 24, -1, -1, }, 
                  { -1, -1, -1, -1, -1, }, 
                  { -1, -1, -1, -1, -1, }, };
            }
        }

        public static double[,] Sharpen48To1
        {
            get
            {
                return new double[,]  
                { { -1, -1, -1, -1, -1, -1, -1,}, 
                  { -1, -1, -1, -1, -1, -1, -1,}, 
                  { -1, -1, -1, -1, -1, -1, -1,}, 
                  { -1, -1, -1, 48, -1, -1, -1,}, 
                  { -1, -1, -1, -1, -1, -1, -1,}, 
                  { -1, -1, -1, -1, -1, -1, -1,}, 
                  { -1, -1, -1, -1, -1, -1, -1,}, };
            }
        }

        public static double[,] Sharpen5To4
        {
            get
            {
                return new double[,]  
                { {  0, -1,  0, }, 
                  { -1,  5, -1, }, 
                  {  0, -1,  0, }, };
            }
        }

        public static double[,] Sharpen10To8
        {
            get
            {
                return new double[,]  
                { {  0, -2,  0, }, 
                  { -2, 10, -2, }, 
                  {  0, -2,  0, }, };
            }
        }

        public static double[,] Sharpen11To8
        {
            get
            {
                return new double[,]  
                { {  0, -2,  0, }, 
                  { -2, 11, -2, }, 
                  {  0, -2,  0, }, };
            }
        }

        public static double[,] Sharpen821
        {
            get
            {
                return new double[,]  
                { { -1, -1, -1, -1, -1, }, 
                  { -1,  2,  2,  2, -1, }, 
                  { -1,  2,  8,  2,  1, },
                  { -1,  2,  2,  2, -1, },
                  { -1, -1, -1, -1, -1, }, };
            }
        }
    }
}

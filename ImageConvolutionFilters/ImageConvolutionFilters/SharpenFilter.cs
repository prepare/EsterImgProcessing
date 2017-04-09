/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageConvolutionFilters
{
    public class SharpenFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "SharpenFilter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, -1, -1, }, 
                            { -1,  9, -1, }, 
                            { -1, -1, -1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class Sharpen3x3Filter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Sharpen3x3Filter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { 0,-1, 0, }, 
                            { -1, 5, -1, }, 
                            { 0,-1, 0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class Sharpen3x3FactorFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Sharpen3x3FactorFilter"; }
        }

        private double factor = 1.0 / 3.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { {  0, -2,  0, }, 
                            { -2, 11, -2, }, 
                            {  0, -2,  0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class Sharpen5x5Filter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Sharpen5x5Filter"; }
        }

        private double factor = 1.0 / 8.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, -1, -1, -1, -1, }, 
                            { -1,  2,  2,  2, -1, }, 
                            { -1,  2,  8,  2,  1, },
                            { -1,  2,  2,  2, -1, },
                            { -1, -1, -1, -1, -1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class IntenseSharpenFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "IntenseSharpenFilter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 0.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { 1,  1,  1, }, 
                            { 1, -7,  1, }, 
                            { 1,  1,  1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }
}

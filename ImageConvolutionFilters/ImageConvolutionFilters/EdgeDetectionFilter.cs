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
    public class EdgeDetectionFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeDetectionFilter"; }
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
                            { -1,  8, -1, }, 
                            { -1, -1, -1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class EdgeDetection45DegreeFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeDetection45DegreeFilter"; }
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
            new double[,] { { -1,  0,  0,  0,  0, }, 
                            {  0, -2,  0,  0,  0, }, 
                            {  0,  0,  6,  0,  0, },
                            {  0,  0,  0, -2,  0, },
                            {  0,  0,  0,  0, -1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class HorizontalEdgeDetectionFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "HorizontalEdgeDetectionFilter"; }
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
            new double[,] { {  0,  0,  0,  0,  0, }, 
                            {  0,  0,  0,  0,  0, }, 
                            { -1, -1,  2,  0,  0, },
                            {  0,  0,  0,  0,  0, },
                            {  0,  0,  0,  0,  0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class VerticalEdgeDetectionFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "VerticalEdgeDetectionFilter"; }
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
            new double[,] { {  0,  0, -1,  0,  0, }, 
                            {  0,  0, -1,  0,  0, }, 
                            {  0,  0,  4,  0,  0, },
                            {  0,  0, -1,  0,  0, },
                            {  0,  0, -1,  0,  0, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class EdgeDetectionTopLeftBottomRightFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EdgeDetectionTopLeftBottomRightFilter"; }
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
            new double[,] { { -5,  0,  0, }, 
                            {  0,  0,  0, }, 
                            {  0,  0,  5, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }
}

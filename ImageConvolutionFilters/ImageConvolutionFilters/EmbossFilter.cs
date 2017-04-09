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
    public class EmbossFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EmbossFilter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 128.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { 2, 0, 0, }, 
                            { 0,-1, 0, }, 
                            { 0, 0,-1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class Emboss45DegreeFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "Emboss45DegreeFilter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 128.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, -1, 0, }, 
                            { -1,  0, 1, }, 
                            {  0,  1, 1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class EmbossTopLeftBottomRightFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "EmbossTopLeftBottomRightFilter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 128.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, 0, 0, }, 
                            {  0, 0, 0, }, 
                            {  0, 0, 1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }

    public class IntenseEmbossFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "IntenseEmbossFilter"; }
        }

        private double factor = 1.0;
        public override double Factor
        {
            get { return factor; }
        }

        private double bias = 128.0;
        public override double Bias
        {
            get { return bias; }
        }

        private double[,] filterMatrix =
            new double[,] { { -1, -1, -1, -1,  0, }, 
                            { -1, -1, -1,  0,  1, }, 
                            { -1, -1,  0,  1,  1, },
                            { -1,  0,  1,  1,  1, },
                            {  0,  1,  1,  1,  1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }
}

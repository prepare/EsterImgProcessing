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
    public class SoftenFilter : ConvolutionFilterBase
    {
        public override string FilterName
        {
            get { return "SoftenFilter"; }
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
            new double[,] { { 1, 1, 1, }, 
                            { 1, 1, 1, }, 
                            { 1, 1, 1, }, };

        public override double[,] FilterMatrix
        {
            get { return filterMatrix; }
        }
    }
}

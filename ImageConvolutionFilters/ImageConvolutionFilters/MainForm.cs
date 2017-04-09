/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageConvolutionFilters
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            List<ConvolutionFilterBase> filterList = new List<ConvolutionFilterBase>();

            filterList.Add(new Blur3x3Filter());
            filterList.Add(new Blur5x5Filter());
            filterList.Add(new Gaussian3x3BlurFilter());
            filterList.Add(new Gaussian5x5BlurFilter());
            filterList.Add(new SoftenFilter());
            filterList.Add(new MotionBlurFilter());
            filterList.Add(new MotionBlurLeftToRightFilter());
            filterList.Add(new MotionBlurRightToLeftFilter());
            filterList.Add(new HighPass3x3Filter());
            filterList.Add(new EdgeDetectionFilter());
            filterList.Add(new HorizontalEdgeDetectionFilter());
            filterList.Add(new VerticalEdgeDetectionFilter());
            filterList.Add(new EdgeDetection45DegreeFilter());
            filterList.Add(new EdgeDetectionTopLeftBottomRightFilter());
            filterList.Add(new SharpenFilter());
            filterList.Add(new Sharpen3x3Filter());
            filterList.Add(new Sharpen3x3FactorFilter());
            filterList.Add(new Sharpen5x5Filter());
            filterList.Add(new IntenseSharpenFilter());
            filterList.Add(new EmbossFilter());
            filterList.Add(new Emboss45DegreeFilter());
            filterList.Add(new EmbossTopLeftBottomRightFilter());
            filterList.Add(new IntenseEmbossFilter());

            cmbFilterType.DataSource = filterList;
            cmbFilterType.DisplayMember = "FilterName";
            cmbFilterType.SelectedIndex = 0;
        }

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                picPreview.Image = previewBitmap;

                ApplyFilter(true);
            }
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            ApplyFilter(false);

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }

        private void ApplyFilter(bool preview)
        {
            if (previewBitmap == null)
            {
                return;
            }

            ConvolutionFilterBase filter = null;

            if (cmbFilterType.SelectedItem is ConvolutionFilterBase)
            {
                filter = (ConvolutionFilterBase)cmbFilterType.SelectedItem;
            }

            if (preview == true)
            {
                picPreview.Image = previewBitmap.ConvolutionFilter(filter);
            }
            else
            {
                resultBitmap = originalBitmap.ConvolutionFilter(filter);
            }
        }

        private void SelectedFilterIndexChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }
    }
}

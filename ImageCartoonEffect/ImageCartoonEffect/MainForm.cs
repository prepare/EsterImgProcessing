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

namespace ImageCartoonEffect
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.None);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Gaussian3x3);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Gaussian5x5);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Gaussian7x7);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Median3x3);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Median5x5);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Median7x7);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Median9x9);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mean3x3);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Mean5x5);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.LowPass3x3);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.LowPass5x5);
            cmbSmoothingFilter.Items.Add(ExtBitmap.SmoothingFilterType.Sharpen3x3);

            cmbSmoothingFilter.SelectedIndex = 0;
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
            if (previewBitmap == null || cmbSmoothingFilter.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            if (preview == true)
            {
                selectedSource = previewBitmap;
            }
            else
            {
                selectedSource = originalBitmap;
            }

            if (selectedSource != null)
            {
                ExtBitmap.SmoothingFilterType filterType = 
                    ((ExtBitmap.SmoothingFilterType)cmbSmoothingFilter.SelectedItem);


                bitmapResult = selectedSource.CartoonEffectFilter(
                                   (byte)trcThreshold.Value, filterType);
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    picPreview.Image = bitmapResult;
                }
                else
                {
                    resultBitmap = bitmapResult;
                }
            }
        }

        private void FilterValueChangedEventHandler(object sender, EventArgs e)
        {
            lblThreshold.Text = trcThreshold.Value.ToString();
            
            ApplyFilter(true);
        }
    }
}

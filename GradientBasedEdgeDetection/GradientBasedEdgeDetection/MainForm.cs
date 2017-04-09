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

namespace GradientBasedEdgeDetection
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbFilterType.Items.Add(ExtBitmap.EdgeFilterType.None);
            cmbFilterType.Items.Add(ExtBitmap.EdgeFilterType.EdgeDetectMono);
            cmbFilterType.Items.Add(ExtBitmap.EdgeFilterType.EdgeDetectGradient);
            cmbFilterType.Items.Add(ExtBitmap.EdgeFilterType.Sharpen);
            cmbFilterType.Items.Add(ExtBitmap.EdgeFilterType.SharpenGradient);

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
            if (previewBitmap == null || cmbFilterType.SelectedIndex == -1)
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
                ExtBitmap.EdgeFilterType filterType = 
                    ((ExtBitmap.EdgeFilterType)cmbFilterType.SelectedItem);

                ExtBitmap.DerivativeLevel derivitaveLevel =
                    (rdFirstDerivative.Checked ? 
                    ExtBitmap.DerivativeLevel.First :
                    ExtBitmap.DerivativeLevel.Second);

                if (filterType == ExtBitmap.EdgeFilterType.None)
                {
                    bitmapResult = selectedSource;
                }
                else
                {
                    bitmapResult = selectedSource.GradientBasedEdgeDetectionFilter(
                                   filterType, derivitaveLevel,
                                   trcRedValue.Value / 100.0f, 
                                   trcGreenValue.Value / 100.0f, 
                                   trcBlueValue.Value / 100.0f, 
                                   (byte)trcThreshold.Value);
                }
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
            lblBlueValue.Text = trcBlueValue.Value.ToString() + "%";
            lblGreenValue.Text = trcGreenValue.Value.ToString() + "%";
            lblRedValue.Text = trcRedValue.Value.ToString() + "%";
            lblThreshold.Text = trcThreshold.Value.ToString();
            
            ApplyFilter(true);
        }
    }
}

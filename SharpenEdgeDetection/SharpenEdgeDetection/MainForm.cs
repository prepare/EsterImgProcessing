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

namespace SharpenEdgeDetection
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.None);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen5To4);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen7To1);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen9To1);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen12To1);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen24To1);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen48To1);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen10To8);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen11To8);
            cmbSharpenFilter.Items.Add(ExtBitmap.SharpenType.Sharpen821);

            cmbSharpenFilter.SelectedIndex = 0;
            cmbMedianFilter.SelectedIndex = 0;
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
            if (previewBitmap == null || cmbSharpenFilter.SelectedIndex == -1)
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
                int medianFilter = Int32.Parse(cmbMedianFilter.SelectedItem.ToString());
                
                ExtBitmap.SharpenType sharpenType =
                    ((ExtBitmap.SharpenType)cmbSharpenFilter.SelectedItem);


                bitmapResult = selectedSource.SharpenEdgeDetect(sharpenType, trcThreshold.Value, chkGrayscale.Checked, chkMonoToneOutput.Checked, medianFilter);
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

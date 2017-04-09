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

namespace ImageArithmetic
{
    public partial class MainForm : Form
    {
        private Bitmap blendBitmap1 = null;
        private Bitmap blendBitmap2 = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.Add);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.Amplitude);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.Average);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.Difference);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.Max);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.Min);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.Multiply);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.SubtractLeft);
            cmbBlendType.Items.Add(ColorCalculator.ColorCalculationType.SubtractRight);

            cmbBlendType.SelectedIndex = 0;
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
            if (blendBitmap1 == null || blendBitmap2 == null || 
                picPreview2.Image == null || 
                picPreview1.Image == null)
            {
                return;
            }

            if (preview == true)
            {
                Bitmap blendPreview = (Bitmap)picPreview1.Image;

                picPreview.Image = blendPreview.ArithmeticBlend((Bitmap)picPreview2.Image,
                                   (ColorCalculator.ColorCalculationType)cmbBlendType.SelectedItem);
            }
            else
            {
                resultBitmap = blendBitmap1.ArithmeticBlend(blendBitmap2,
                               (ColorCalculator.ColorCalculationType)cmbBlendType.SelectedItem);
            }
        }

        private void BlendTypeSelectedIndexChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        private void LoadImageButtonClickedEventHandler(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (sender == btnLoadPreview1)
                {
                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    blendBitmap1 = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                    streamReader.Close();

                    picPreview1.Image = blendBitmap1.CopyToSquareCanvas(picPreview.Width);
                     
                }
                else if (sender == btnLoadPreview2)
                {
                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    blendBitmap2 = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                    streamReader.Close();

                    picPreview2.Image = blendBitmap2.CopyToSquareCanvas(picPreview.Width);
                }

                ApplyFilter(true);
            }
        }
    }
}

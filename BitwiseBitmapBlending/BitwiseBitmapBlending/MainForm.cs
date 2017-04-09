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

namespace BitmapShading
{
    public partial class MainForm : Form
    {
        private Bitmap sourceBitmap = null;
        private Bitmap blendBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbBlueBlendType.Items.Add(ExtBitmap.BitwiseBlendType.None);
            cmbBlueBlendType.Items.Add(ExtBitmap.BitwiseBlendType.And);
            cmbBlueBlendType.Items.Add(ExtBitmap.BitwiseBlendType.Or);
            cmbBlueBlendType.Items.Add(ExtBitmap.BitwiseBlendType.Xor);
            cmbBlueBlendType.SelectedIndex = 0;

            cmbGreenBlendType.Items.Add(ExtBitmap.BitwiseBlendType.None);
            cmbGreenBlendType.Items.Add(ExtBitmap.BitwiseBlendType.And);
            cmbGreenBlendType.Items.Add(ExtBitmap.BitwiseBlendType.Or);
            cmbGreenBlendType.Items.Add(ExtBitmap.BitwiseBlendType.Xor);
            cmbGreenBlendType.SelectedIndex = 0;

            cmbRedBlendType.Items.Add(ExtBitmap.BitwiseBlendType.None);
            cmbRedBlendType.Items.Add(ExtBitmap.BitwiseBlendType.And);
            cmbRedBlendType.Items.Add(ExtBitmap.BitwiseBlendType.Or);
            cmbRedBlendType.Items.Add(ExtBitmap.BitwiseBlendType.Xor);
            cmbRedBlendType.SelectedIndex = 0;
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
            if (sourceBitmap == null || blendBitmap == null || 
                picBlendPreview.Image == null || 
                picSourcePreview.Image == null)
            {
                return;
            }

            if (preview == true)
            {
                Bitmap sourcePreview = (Bitmap)picSourcePreview.Image;

                picPreview.Image = sourcePreview.BitwiseBlend((Bitmap)picBlendPreview.Image,
                                   (ExtBitmap.BitwiseBlendType)cmbBlueBlendType.SelectedItem,
                                   (ExtBitmap.BitwiseBlendType)cmbGreenBlendType.SelectedItem,
                                   (ExtBitmap.BitwiseBlendType)cmbRedBlendType.SelectedItem);
            }
            else
            {
                resultBitmap = sourceBitmap.BitwiseBlend(blendBitmap,
                                   (ExtBitmap.BitwiseBlendType)cmbBlueBlendType.SelectedItem,
                                   (ExtBitmap.BitwiseBlendType)cmbGreenBlendType.SelectedItem,
                                   (ExtBitmap.BitwiseBlendType)cmbRedBlendType.SelectedItem);
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
                if (sender == btnLoadSourceImage)
                {
                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    sourceBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                    streamReader.Close();

                    picSourcePreview.Image = sourceBitmap.CopyToSquareCanvas(picPreview.Width);
                     
                }
                else if (sender == btnLoadBlendImage)
                {
                    StreamReader streamReader = new StreamReader(ofd.FileName);
                    blendBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                    streamReader.Close();

                    picBlendPreview.Image = blendBitmap.CopyToSquareCanvas(picPreview.Width);
                }

                ApplyFilter(true);
            }
        }
    }
}

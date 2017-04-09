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

namespace BitmapPixelManipulation
{
    public partial class MainForm : Form
    {
        private Bitmap sourceBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbFilterType.Items.Add(ColourSwapType.ShiftLeft);
            cmbFilterType.Items.Add(ColourSwapType.ShiftRight);
            cmbFilterType.Items.Add(ColourSwapType.SwapBlueAndGreen);
            cmbFilterType.Items.Add(ColourSwapType.SwapBlueAndGreenFixRed);
            cmbFilterType.Items.Add(ColourSwapType.SwapBlueAndRed);
            cmbFilterType.Items.Add(ColourSwapType.SwapBlueAndRedFixGreen);
            cmbFilterType.Items.Add(ColourSwapType.SwapRedAndGreen);
            cmbFilterType.Items.Add(ColourSwapType.SwapRedAndGreenFixBlue);

            cmbFilterType.SelectedIndex = 0;

            cmbInvertColoursType.Items.Add(ColourInversionType.All);
            cmbInvertColoursType.Items.Add(ColourInversionType.Blue);
            cmbInvertColoursType.Items.Add(ColourInversionType.BlueGreen);
            cmbInvertColoursType.Items.Add(ColourInversionType.BlueRed);
            cmbInvertColoursType.Items.Add(ColourInversionType.Green);
            cmbInvertColoursType.Items.Add(ColourInversionType.Red);
            cmbInvertColoursType.Items.Add(ColourInversionType.RedGreen);

            cmbInvertColoursType.SelectedIndex = 0;
        }

        private void FilterControlsValueChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        private void ApplyFilter(bool preview)
        {
            cmbInvertColoursType.Enabled = chkInvertColours.Checked;
            cmbFilterType.Enabled = chkSwapColours.Checked;
            lblFixedValue.Text = "Fixed Value: " + trcFixedValue.Value.ToString();

            Bitmap bitmapResult = null;

            if (picSource.Image == null)
            {
                return;
            }

            if (preview == true)
            {
                bitmapResult = new Bitmap(picSource.Image);
            }
            else
            {
                bitmapResult = new Bitmap(sourceBitmap);
            }

            if (bitmapResult == null)
            {
                return;
            }

            if (chkFlipPixels.Checked == true)
            {
                bitmapResult = bitmapResult.FlipPixels();
            }

            if (chkInvertColours.Checked == true)
            {
                ColourInversionType inversionType = (ColourInversionType)cmbInvertColoursType.SelectedItem;
                bitmapResult = bitmapResult.InvertColors(inversionType);
            }

            if (chkSwapColours.Checked == true)
            {
                ColourSwapType swapType = (ColourSwapType)cmbFilterType.SelectedItem;
                bitmapResult = bitmapResult.SwapColors(swapType, (byte)trcFixedValue.Value);
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    picResult.Image = bitmapResult;
                }
                else
                {
                    resultBitmap = bitmapResult;
                }
            }
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
                sourceBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                picSource.Image = sourceBitmap.CopyToSquareCanvas(picSource.Width);

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
    }
}

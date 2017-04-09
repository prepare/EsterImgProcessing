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

namespace BitmapArgbSwapping
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            cmbFilterType.Items.Add(ColorSwapFilter.ColorSwapType.ShiftLeft);
            cmbFilterType.Items.Add(ColorSwapFilter.ColorSwapType.ShiftRight);
            cmbFilterType.Items.Add(ColorSwapFilter.ColorSwapType.SwapBlueAndGreen);
            cmbFilterType.Items.Add(ColorSwapFilter.ColorSwapType.SwapBlueAndRed);
            cmbFilterType.Items.Add(ColorSwapFilter.ColorSwapType.SwapRedAndGreen);

            cmbFilterType.SelectedIndex = 0;
        }

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png files (*.png)|*.png|Bitmap files (*.bmp)|*.bmp|Jpeg files (*.jpg)|*.jpg";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                Bitmap sourceBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                picSource.Image = sourceBitmap;

                ApplyFilter();
            }
        }

        private void ApplyFilter()
        {
            if (picSource.Image != null)
            {
                ColorSwapFilter swapFilter = new ColorSwapFilter();
                swapFilter.SwapType = (ColorSwapFilter.ColorSwapType)cmbFilterType.SelectedItem;
                swapFilter.InvertColorsWhenSwapping = chkInvertColours.Checked;
                swapFilter.SwapHalfColorValues = chkHalfColours.Checked;

                picResult.Image = ((Bitmap)(picSource.Image)).SwapColorsCopy(swapFilter);
            }
        }

        private void FilterValueChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            if (picResult.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg|Bitmap Images(*.bmp)|*.bmp";

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
                    picResult.Image.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
        }
    }
}

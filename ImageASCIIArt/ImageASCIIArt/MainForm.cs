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

namespace ImageASCIIArt
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();
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

                ApplyFilter();
            }
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            if (txtAscii.Text == String.Empty)
            {
                return;
            }

            

            Font textFont = new System.Drawing.Font(txtAscii.Font.Name, (float)numFontSize.Value, txtAscii.Font.Style);
            Bitmap textBitmap = originalBitmap.ASCIIFilter((int)numPixelsToChar.Value).TextToImage(textFont, (float)(numZoom.Value / 100));

            if (textBitmap != null)
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
                    textBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    textBitmap.Dispose();
                }
            }
        }

        private void ApplyFilter()
        {
            if (originalBitmap != null)
            {
                txtAscii.Text = originalBitmap.ScaleBitmap((float)(numZoom.Value / 100)).ASCIIFilter((int)numPixelsToChar.Value, (int)numColors.Value);
            }
        }

        private void FilterValueChangedEventHandler(object sender, EventArgs e)
        {
            txtAscii.Font = new System.Drawing.Font(txtAscii.Font.Name, (float)numFontSize.Value, txtAscii.Font.Style);
            
            ApplyFilter();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtAscii.Rtf, TextDataFormat.Rtf);
        }
    }
}

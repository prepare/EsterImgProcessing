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

namespace BiTonalBitmap
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
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

            if (preview == true)
            {
                picPreview.Image = previewBitmap.Bitonal(pnlDarkColour.BackColor, pnlLightColour.BackColor, trcThreshold.Value);
            }
            else
            {
                resultBitmap = originalBitmap.Bitonal(pnlDarkColour.BackColor, pnlLightColour.BackColor, trcThreshold.Value);
            }
        }

        private void ColourComponentValueChangedEventHandler(object sender, EventArgs e)
        {
            lblThresholdValue.Text = trcThreshold.Value.ToString();

            ApplyFilter(true);
        }

        private void ColourPanelClickEventHandler(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel tmp = (Panel)sender;

                ColorDialog cld = new ColorDialog();
                cld.AllowFullOpen = true;
                cld.Color = tmp.BackColor;
                cld.FullOpen = true;

                if (cld.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tmp.BackColor = cld.Color;
                    ApplyFilter(true);
                }
            }
        }
    }
}

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

namespace StainedGlassImageFilter
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbDistanceType.Items.Add(ExtBitmap.DistanceFormulaType.Euclidean);
            cmbDistanceType.Items.Add(ExtBitmap.DistanceFormulaType.Manhattan);
            cmbDistanceType.Items.Add(ExtBitmap.DistanceFormulaType.Chebyshev);

            cmbDistanceType.SelectedIndex = 0;
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

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            ExtBitmap.DistanceFormulaType distanceType = (ExtBitmap.DistanceFormulaType)cmbDistanceType.SelectedItem;

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
                bitmapResult = selectedSource.StainedGlassColorFilter((int)numBlockSize.Value, (double)numBlockFactor.Value, distanceType, chkHighlightEdges.Checked, (byte)numEdgeThreshold.Value, btnColour.BackColor);
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
            numEdgeThreshold.Enabled = chkHighlightEdges.Checked;
            ApplyFilter(true);
        }

        private void btnColour_Click(object sender, EventArgs e)
        {
            ColorDialog cldg = new ColorDialog();

            cldg.AllowFullOpen = true;
            cldg.Color = btnColour.BackColor;
            cldg.FullOpen = true;
            cldg.AnyColor = true;

            if (cldg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                btnColour.BackColor = cldg.Color;
            }

            ApplyFilter(true);
        }
    }
}

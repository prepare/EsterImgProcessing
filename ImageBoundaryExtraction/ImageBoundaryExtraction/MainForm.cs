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

namespace ImageBoundaryExtraction 
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbFilterType.Items.Add(ExtBitmap.BoundaryExtractionFilterType.BoundaryExtraction);
            cmbFilterType.Items.Add(ExtBitmap.BoundaryExtractionFilterType.BoundarySharpen);
            cmbFilterType.Items.Add(ExtBitmap.BoundaryExtractionFilterType.BoundaryTrace);

            cmbFilterSize.SelectedIndex = 0;
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
            if (previewBitmap == null || cmbFilterSize.SelectedIndex == -1)
            {
                return;
            }

            if (preview == true && chkLivePreview.Checked == false)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;
            ExtBitmap.BoundaryExtractionFilterType filterType = (ExtBitmap.BoundaryExtractionFilterType)cmbFilterType.SelectedItem;

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
                if (cmbFilterSize.SelectedItem.ToString() == "None")
                {
                    bitmapResult = selectedSource;
                }
                else
                {
                    int filterSize = 0;

                    if(Int32.TryParse(cmbFilterSize.SelectedItem.ToString(), out filterSize))
                    {
                        bool[,] se = GetSE();

                        bitmapResult = selectedSource.BoundaryExtractionFilter(se, filterType, chkB.Checked, chkG.Checked, chkR.Checked);
                    }
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
            ApplyFilter(true);
        }

        private void FilterSizeValueChangedEventHandler(object sender, EventArgs e)
        {
            if (cmbFilterSize.SelectedItem.ToString() != "None")
            {
                int filterSize = 0;
                
                if (Int32.TryParse(cmbFilterSize.SelectedItem.ToString(), out filterSize))
                {
                    pnlSE.Controls.Clear();


                    for (int row = 0; row < filterSize; row++)
                    {
                        for (int col = 0; col < filterSize; col++)
                        {
                            CheckBox chk = new CheckBox();
                            chk.Checked = true;
                            chk.Tag = new Point(row, col);
                            chk.Text = String.Empty;
                            chk.Width = 20;

                            chk.Location = new Point(5 + chk.Width * col + 2 * col, 5 + chk.Height * row + 2 * row);
                            chk.CheckedChanged += new EventHandler(SCCheckedChanged);

                            pnlSE.Controls.Add(chk);
                        }
                    }
                }
            }

            ApplyFilter(true);
        }

        private void SCCheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        private bool[,] GetSE()
        {
            bool[,] se = new bool[0,0];
            
            if (cmbFilterSize.SelectedItem.ToString() != "None")
            {
                int filterSize = 0;

                if (Int32.TryParse(cmbFilterSize.SelectedItem.ToString(), out filterSize))
                {
                    se = new bool[filterSize, filterSize];

                    for (int k = 0; k < pnlSE.Controls.Count; k++)
                    {
                        if (pnlSE.Controls[k] is CheckBox)
                        {
                            if (pnlSE.Controls[k].Tag is Point)
                            {
                                Point tmpXY = (Point)pnlSE.Controls[k].Tag;

                                if (tmpXY.X < filterSize && tmpXY.Y < filterSize)
                                {
                                    se[tmpXY.X, tmpXY.Y] = ((CheckBox)pnlSE.Controls[k]).Checked;
                                }
                            }
                        }
                    }
                }
            }

            return se;
        }
    }
}

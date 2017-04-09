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

namespace BitmapColorSubstitution
{
    public partial class MainForm : Form
    {
        ColorSubstitutionFilter filterData = new ColorSubstitutionFilter();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void ApplyFilter()
        {
            if (picSource.Image != null)
            {
                filterData.SourceColor = pnlSourceColor.BackColor;
                filterData.ThresholdValue = (byte)(255.0f / 100.0f * (float)trcThreshHold.Value);
                filterData.NewColor = pnlResultColor.BackColor;

                picResult.Image = ((Bitmap)picSource.Image).ColorSubstitution(filterData);

                pnlFilter.Enabled = true;
                btnSave.Enabled = true;
                btnResultAsSource.Enabled = true;
            }
        }

        private void PictureBoxMouseUpEventHandler(object sender, MouseEventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox eventSource = (PictureBox)sender;

                using (Bitmap bmpSource = new Bitmap(eventSource.Width, eventSource.Height))
                {
                    picSource.DrawToBitmap(bmpSource, new Rectangle(0, 0, eventSource.Width, eventSource.Height));
                    pnlSourceColor.BackColor = bmpSource.GetPixel(e.X, e.Y);
                }

                ApplyFilter();
            }
        }

        private void trcThreshHold_ValueChanged(object sender, EventArgs e)
        {
            lblThreshold.Text = "Threshold \r\n" + trcThreshHold.Value.ToString() + "%";
            
            ApplyFilter();
        }

        private void btnResultAsSource_Click(object sender, EventArgs e)
        {
            picSource.Image = ((Bitmap)picResult.Image).Format32bppArgbCopy();
        }

        private void ShowColorDialogButtonClickEventHandler(object sender, EventArgs e)
        {
            using (ColorDialog colorDlg = new ColorDialog())
            {
                colorDlg.AllowFullOpen = true;
                colorDlg.AnyColor = true;
                colorDlg.FullOpen = true;

                if (sender == btnSelectColorToReplace)
                {
                    colorDlg.Color = pnlSourceColor.BackColor;
                }
                else if (sender == btnSelectReplacementColor)
                {
                    colorDlg.Color = pnlResultColor.BackColor;
                }

                if (colorDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (sender == btnSelectColorToReplace)
                    {
                        pnlSourceColor.BackColor = colorDlg.Color;
                    }
                    else if (sender == btnSelectReplacementColor)
                    {
                        pnlResultColor.BackColor = colorDlg.Color;
                    }
                    
                    ApplyFilter();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Specify a Source file name and file path";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                Bitmap sourceBitmap = new Bitmap(streamReader.BaseStream);
                streamReader.Close();

                picSource.Image = sourceBitmap.Format32bppArgbCopy();

                ApplyFilter();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
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

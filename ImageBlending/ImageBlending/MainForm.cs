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
using System.Drawing.Imaging;
using System.IO;

namespace ImageBlending
{
    public partial class MainForm : Form
    {
        private BitmapFilterData filterData = new BitmapFilterData();

        private string overlayImagePath = String.Empty;

        private Bitmap bitmapResult = null;

        private bool ignoreControlEvents = false;

        public MainForm()
        {
            InitializeComponent();

            cmbBlendTypeBlue.Items.Add(ColorComponentBlendType.Add);
            cmbBlendTypeBlue.Items.Add(ColorComponentBlendType.Average);
            cmbBlendTypeBlue.Items.Add(ColorComponentBlendType.AscendingOrder);
            cmbBlendTypeBlue.Items.Add(ColorComponentBlendType.DescendingOrder);
            cmbBlendTypeBlue.Items.Add(ColorComponentBlendType.Subtract);

            cmbBlendTypeBlue.SelectedIndex = 0;

            cmbBlendTypeGreen.Items.Add(ColorComponentBlendType.Add);
            cmbBlendTypeGreen.Items.Add(ColorComponentBlendType.Average);
            cmbBlendTypeGreen.Items.Add(ColorComponentBlendType.AscendingOrder);
            cmbBlendTypeGreen.Items.Add(ColorComponentBlendType.DescendingOrder);
            cmbBlendTypeGreen.Items.Add(ColorComponentBlendType.Subtract);

            cmbBlendTypeGreen.SelectedIndex = 0;

            cmbBlendTypeRed.Items.Add(ColorComponentBlendType.Add);
            cmbBlendTypeRed.Items.Add(ColorComponentBlendType.Average);
            cmbBlendTypeRed.Items.Add(ColorComponentBlendType.AscendingOrder);
            cmbBlendTypeRed.Items.Add(ColorComponentBlendType.DescendingOrder);
            cmbBlendTypeRed.Items.Add(ColorComponentBlendType.Subtract);

            cmbBlendTypeRed.SelectedIndex = 0;
        }

        private void BtnLoadSourceImageClickEventHandler(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the source Image";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picSource.Image = ofd.FileName.LoadArgbBitmap();
                CreateOverlayImage();

                RenderOverlayBitmap();
            }
        }

        private void BtnOverlayImageClickEventHandler(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the overlay Image";
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                overlayImagePath = ofd.FileName;
                CreateOverlayImage();

                RenderOverlayBitmap();
            }
        }

        private void CreateOverlayImage()
        {
            if (overlayImagePath != String.Empty)
            {
                Size? sourceDimensions = null;

                if (picSource.Image != null)
                {
                    sourceDimensions = new Size(picSource.Image.Width, picSource.Image.Height);
                }

                picOverlay.Image = overlayImagePath.LoadArgbBitmap(sourceDimensions);
            }
        }

        private void RenderOverlayBitmap()
        {
            if (picSource.Image == null || picOverlay.Image == null || ignoreControlEvents == true)
            {
                return;
            }

            filterData.BlendTypeBlue = (ColorComponentBlendType)cmbBlendTypeBlue.SelectedItem;
            filterData.BlendTypeGreen = (ColorComponentBlendType)cmbBlendTypeGreen.SelectedItem;
            filterData.BlendTypeRed = (ColorComponentBlendType)cmbBlendTypeRed.SelectedItem;

            filterData.OverlayBlueEnabled = chkEnableOverlayBlue.Checked;
            filterData.OverlayGreenEnabled = chkEnableOverlayGreen.Checked;
            filterData.OverlayRedEnabled = chkEnableOverlayRed.Checked;

            filterData.OverlayBlueLevel = (float)trcOverlayBlueLevel.Value / 100.0f;
            filterData.OverlayGreenLevel = (float)trcOverlayGreenLevel.Value / 100.0f;
            filterData.OverlayRedLevel = (float)trcOverlayRedLevel.Value / 100.0f;

            filterData.SourceBlueEnabled = chkEnableSourceBlue.Checked;
            filterData.SourceGreenEnabled = chkEnableSourceGreen.Checked;
            filterData.SourceRedEnabled = chkEnableSourceRed.Checked;

            filterData.SourceBlueLevel = (float)trcSourceBlueLevel.Value / 100.0f;
            filterData.SourceGreenLevel = (float)trcSourceGreenLevel.Value / 100.0f;
            filterData.SourceRedLevel = (float)trcSourceRedLevel.Value / 100.0f;

            using (Bitmap bmpPictureBoxSource = picSource.GetBitmap())
            {
                using (Bitmap bmpPictureBoxOverlay = picOverlay.GetBitmap())
                {
                    bitmapResult = bmpPictureBoxSource.BlendImage(bmpPictureBoxOverlay, filterData);
                    picResult.Image = bitmapResult;
                }
            }
        }

        private void ImageBlendMethodChangedEventHandler(object sender, EventArgs e)
        {
            RenderOverlayBitmap();
        }

        private void ColourLevelChangedEventHandler(object sender, EventArgs e)
        {
            lblSourceLevelBlue.Text = "B: " + trcSourceBlueLevel.Value + "%";
            lblSourceLevelGreen.Text = "G: " + trcSourceGreenLevel.Value + "%";
            lblSourceLevelRed.Text = "R: " + trcSourceRedLevel.Value + "%";

            lblOverlayLevelBlue.Text = "B: " + trcOverlayBlueLevel.Value + "%";
            lblOverlayLevelGreen.Text = "G: " + trcOverlayGreenLevel.Value + "%";
            lblOverlayLevelRed.Text = "R: " + trcOverlayRedLevel.Value + "%";

            RenderOverlayBitmap();
        }

        private void ColorCheckedChangedEventHandler(object sender, EventArgs e)
        {
            RenderOverlayBitmap();
        }

        private void btnSaveBlendResult_Click(object sender, EventArgs e)
        {
            if (bitmapResult == null)
            {
                return;
            }
            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Specify a file name and file path";
            sfd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileExtension = Path.GetExtension(sfd.FileName);
                ImageFormat imgFormat = ImageFormat.Png;

                if(fileExtension == "BMP")
                {
                    imgFormat = ImageFormat.Bmp;
                }
                else if(fileExtension == "JPG")
                {
                    imgFormat = ImageFormat.Jpeg;
                }

                StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                picResult.Image.Save(streamWriter.BaseStream, imgFormat);
                streamWriter.Flush();
                streamWriter.Close();
            }
            
        }

        private void btnSaveFilter_Click(object sender, EventArgs e)
        {
            if (filterData == null)
            {
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Specify a file name and file path";
            sfd.Filter = "Image Filter Files(*.xbmp)|*.xbmp";
            sfd.AddExtension = true;

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string xmlString = BitmapFilterData.XmlSerialize(filterData);

                File.WriteAllText(sfd.FileName, xmlString, Encoding.UTF8);
            }
        }

        private void btnLoadFilter_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select the Image Filter to load";
            ofd.Filter = "Image Filter Files(*.xbmp)|*.xbmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string xmlString = File.ReadAllText(ofd.FileName, Encoding.UTF8);

                BitmapFilterData tmpFilter = BitmapFilterData.XmlDeserialize(xmlString);

                if (tmpFilter == null)
                {
                    MessageBox.Show("The selected file could not be processed!", "Filter File Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                filterData = tmpFilter;

                PopulateControls();

                RenderOverlayBitmap();
            }
        }

        private void PopulateControls()
        {
            ignoreControlEvents = true;

            chkEnableSourceBlue.Checked = filterData.SourceBlueEnabled;
            chkEnableSourceGreen.Checked = filterData.SourceGreenEnabled;
            chkEnableSourceRed.Checked = filterData.SourceRedEnabled;

            chkEnableOverlayBlue.Checked = filterData.OverlayBlueEnabled;
            chkEnableOverlayGreen.Checked = filterData.OverlayGreenEnabled;
            chkEnableOverlayRed.Checked = filterData.OverlayRedEnabled;

            trcSourceBlueLevel.Value = (int)(filterData.SourceBlueLevel * 100);
            trcSourceGreenLevel.Value = (int)(filterData.SourceGreenLevel * 100);
            trcSourceRedLevel.Value = (int)(filterData.SourceRedLevel * 100);

            trcOverlayBlueLevel.Value = (int)(filterData.OverlayBlueLevel * 100);
            trcOverlayGreenLevel.Value = (int)(filterData.OverlayGreenLevel * 100);
            trcOverlayRedLevel.Value = (int)(filterData.OverlayRedLevel * 100);

            cmbBlendTypeBlue.SelectedItem = filterData.BlendTypeBlue;
            cmbBlendTypeGreen.SelectedItem = filterData.BlendTypeGreen;
            cmbBlendTypeRed.SelectedItem = filterData.BlendTypeRed;

            ignoreControlEvents = false;
        }
    }
}

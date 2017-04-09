using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ImageToIcon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            cmbIconSize.Items.Add(IconSizeDimensions.IconSize16x16Pixels);
            cmbIconSize.Items.Add(IconSizeDimensions.IconSize24x24Pixels);
            cmbIconSize.Items.Add(IconSizeDimensions.IconSize32x32Pixels);
            cmbIconSize.Items.Add(IconSizeDimensions.IconSize48x48Pixels);
            cmbIconSize.Items.Add(IconSizeDimensions.IconSize64x64Pixels);
            cmbIconSize.Items.Add(IconSizeDimensions.IconSize96x96Pixels);
            cmbIconSize.Items.Add(IconSizeDimensions.IconSize128x128Pixels);

            cmbIconSize.SelectedIndex = 4;
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Specify a Source file name and file path";
            ofd.Filter = "Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(ofd.FileName))
                {
                    Bitmap sourceBitmap = new Bitmap(streamReader.BaseStream);
                    streamReader.Close();

                    picSource.Image = sourceBitmap.Format32bppArgbCopy();
                }
            }
        }

        private void btnSaveIcon_Click(object sender, EventArgs e)
        {
            if (picSource.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Icon Files(*.ico)|*.ico";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.Drawing.Icon tempIcon = ((Bitmap)picSource.Image).CreateIcon(
                                                    (IconSizeDimensions)cmbIconSize.SelectedItem);

                    using (StreamWriter streamWriter = new StreamWriter(sfd.FileName, false))
                    {
                        tempIcon.Save(streamWriter.BaseStream);

                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                }
            }
        }
    }
}

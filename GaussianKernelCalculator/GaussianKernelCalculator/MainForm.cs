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

namespace GaussianKernelCalculator
{
    public partial class MainForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        private double[,] currentMatrix = null;
        
        public MainForm()
        {
            InitializeComponent();

            cmbKernelLenght.SelectedIndex = 0;
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

            if (preview == true)
            {
                selectedSource = previewBitmap;
            }
            else
            {
                selectedSource = originalBitmap;
            }

            if (selectedSource != null && currentMatrix != null)
            {
                bitmapResult = selectedSource.ConvolutionFilter(currentMatrix);
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtKernal.Text = String.Empty;

            double weight = (double)numKernelWeight.Value;
            int lenght = Int32.Parse(cmbKernelLenght.SelectedItem.ToString());

            currentMatrix = MatrixCalculator.Calculate(lenght, weight);

            if (currentMatrix != null)
            {
                for (int row = 0; row < lenght; row++)
                {
                    txtKernal.Text += "|";

                    for (int col = 0; col < lenght; col++)
                    {
                        txtKernal.Text += currentMatrix[row, col].ToString("F5") + "|";
                    }

                    txtKernal.Text += "\r\n";
                }
            }

            ApplyFilter(true);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCopyCSharp_Click(object sender, EventArgs e)
        {
            if (currentMatrix != null)
            {
                StringBuilder matrixText = new StringBuilder();

                matrixText.Append("{ ");

                for (int row = 0; row < currentMatrix.GetLength(0); row++)
                {
                    if (row == 0)
                    {
                        matrixText.Append("{ ");
                    }
                    else
                    {
                        matrixText.Append("  { ");
                    }
                    
                    for (int col = 0; col < currentMatrix.GetLength(1); col++)
                    {
                        matrixText.Append(" " + currentMatrix[row, col].ToString() + " , ");
                    }

                    matrixText.Append("}, ");

                    if (row < currentMatrix.GetLength(0) - 1)
                    {
                        matrixText.AppendLine();
                    }
                }

                matrixText.Append(" }; ");

                Clipboard.SetText(matrixText.ToString());
            }
        }

        private void btnCopyText_Click(object sender, EventArgs e)
        {
            if (currentMatrix != null)
            {
                StringBuilder matrixText = new StringBuilder();

                for (int row = 0; row < currentMatrix.GetLength(0); row++)
                {
                    for (int col = 0; col < currentMatrix.GetLength(1); col++)
                    {
                        matrixText.Append(currentMatrix[row, col].ToString() + "\t");
                    }

                    matrixText.AppendLine();
                }

                Clipboard.SetText(matrixText.ToString());
            }
        }
    }
}

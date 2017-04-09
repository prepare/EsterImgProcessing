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

namespace GdiOpacityDrawing
{
    public partial class MainForm : Form
    {
        private byte foreColorAlphaValue = 100;
        private string textToDisplay = "http://softwarebydefault.com";
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormPaintEventHandler(object sender, PaintEventArgs e)
        {
            Color alphaForeColor = Color.FromArgb(this.foreColorAlphaValue, this.ForeColor);
            Pen rectanglePen = new Pen(alphaForeColor, 2.0f);
            SolidBrush textBrush = new SolidBrush(alphaForeColor);

            float x = this.ClientRectangle.Width / 2.0f;
            x -= e.Graphics.MeasureString(textToDisplay, this.Font).Width / 2.0f;

            float y = this.ClientRectangle.Height / 2.0f;
            y -= e.Graphics.MeasureString(textToDisplay, this.Font).Height / 2.0f;

            e.Graphics.DrawString(textToDisplay, this.Font, textBrush, new PointF(x, y));

            e.Graphics.DrawRectangle(rectanglePen, 25, 25, 
                this.ClientRectangle.Width - 50, this.ClientRectangle.Height - 50);
        }
    }
}

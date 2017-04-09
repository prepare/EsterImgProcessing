namespace ImageTransformRotate
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.numDegreesBlue = new System.Windows.Forms.NumericUpDown();
            this.numDegreesGreen = new System.Windows.Forms.NumericUpDown();
            this.numDegreesRed = new System.Windows.Forms.NumericUpDown();
            this.pnlRotate = new System.Windows.Forms.Panel();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblDegreeRotation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesRed)).BeginInit();
            this.pnlRotate.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(600, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(619, 514);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(252, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(619, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(251, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // numDegreesBlue
            // 
            this.numDegreesBlue.DecimalPlaces = 2;
            this.numDegreesBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDegreesBlue.Location = new System.Drawing.Point(115, 61);
            this.numDegreesBlue.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numDegreesBlue.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numDegreesBlue.Name = "numDegreesBlue";
            this.numDegreesBlue.Size = new System.Drawing.Size(103, 31);
            this.numDegreesBlue.TabIndex = 21;
            this.numDegreesBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDegreesBlue.ValueChanged += new System.EventHandler(this.DegreesValueChangedEventHandler);
            // 
            // numDegreesGreen
            // 
            this.numDegreesGreen.DecimalPlaces = 2;
            this.numDegreesGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDegreesGreen.Location = new System.Drawing.Point(115, 99);
            this.numDegreesGreen.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numDegreesGreen.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numDegreesGreen.Name = "numDegreesGreen";
            this.numDegreesGreen.Size = new System.Drawing.Size(103, 31);
            this.numDegreesGreen.TabIndex = 22;
            this.numDegreesGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDegreesGreen.ValueChanged += new System.EventHandler(this.DegreesValueChangedEventHandler);
            // 
            // numDegreesRed
            // 
            this.numDegreesRed.DecimalPlaces = 2;
            this.numDegreesRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDegreesRed.Location = new System.Drawing.Point(115, 137);
            this.numDegreesRed.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numDegreesRed.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numDegreesRed.Name = "numDegreesRed";
            this.numDegreesRed.Size = new System.Drawing.Size(103, 31);
            this.numDegreesRed.TabIndex = 23;
            this.numDegreesRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDegreesRed.ValueChanged += new System.EventHandler(this.DegreesValueChangedEventHandler);
            // 
            // pnlRotate
            // 
            this.pnlRotate.BackColor = System.Drawing.Color.Silver;
            this.pnlRotate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRotate.Controls.Add(this.lblRed);
            this.pnlRotate.Controls.Add(this.numDegreesRed);
            this.pnlRotate.Controls.Add(this.lblGreen);
            this.pnlRotate.Controls.Add(this.numDegreesGreen);
            this.pnlRotate.Controls.Add(this.lblBlue);
            this.pnlRotate.Controls.Add(this.numDegreesBlue);
            this.pnlRotate.Controls.Add(this.lblDegreeRotation);
            this.pnlRotate.Location = new System.Drawing.Point(619, 12);
            this.pnlRotate.Name = "pnlRotate";
            this.pnlRotate.Size = new System.Drawing.Size(251, 189);
            this.pnlRotate.TabIndex = 24;
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(3, 132);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(106, 38);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Red:";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(3, 94);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(106, 38);
            this.lblGreen.TabIndex = 2;
            this.lblGreen.Text = "Green:";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(3, 56);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(106, 38);
            this.lblBlue.TabIndex = 1;
            this.lblBlue.Text = "Blue:";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDegreeRotation
            // 
            this.lblDegreeRotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreeRotation.Location = new System.Drawing.Point(3, 6);
            this.lblDegreeRotation.Name = "lblDegreeRotation";
            this.lblDegreeRotation.Size = new System.Drawing.Size(243, 38);
            this.lblDegreeRotation.TabIndex = 0;
            this.lblDegreeRotation.Text = "Degree of Rotation";
            this.lblDegreeRotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(882, 625);
            this.Controls.Add(this.pnlRotate);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Transform Rotate";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDegreesRed)).EndInit();
            this.pnlRotate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.NumericUpDown numDegreesBlue;
        private System.Windows.Forms.NumericUpDown numDegreesGreen;
        private System.Windows.Forms.NumericUpDown numDegreesRed;
        private System.Windows.Forms.Panel pnlRotate;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblDegreeRotation;
    }
}


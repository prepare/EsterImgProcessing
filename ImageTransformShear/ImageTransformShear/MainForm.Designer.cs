namespace ImageTransformShear
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
            this.numShearX = new System.Windows.Forms.NumericUpDown();
            this.numShearY = new System.Windows.Forms.NumericUpDown();
            this.pnlRotate = new System.Windows.Forms.Panel();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.lblShearFactor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearY)).BeginInit();
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
            // numShearX
            // 
            this.numShearX.DecimalPlaces = 2;
            this.numShearX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numShearX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numShearX.Location = new System.Drawing.Point(115, 61);
            this.numShearX.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numShearX.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numShearX.Name = "numShearX";
            this.numShearX.Size = new System.Drawing.Size(103, 31);
            this.numShearX.TabIndex = 21;
            this.numShearX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numShearX.ValueChanged += new System.EventHandler(this.ShearValueChangedEventHandler);
            // 
            // numShearY
            // 
            this.numShearY.DecimalPlaces = 2;
            this.numShearY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numShearY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numShearY.Location = new System.Drawing.Point(115, 99);
            this.numShearY.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numShearY.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.numShearY.Name = "numShearY";
            this.numShearY.Size = new System.Drawing.Size(103, 31);
            this.numShearY.TabIndex = 22;
            this.numShearY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numShearY.ValueChanged += new System.EventHandler(this.ShearValueChangedEventHandler);
            // 
            // pnlRotate
            // 
            this.pnlRotate.BackColor = System.Drawing.Color.Silver;
            this.pnlRotate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRotate.Controls.Add(this.lblY);
            this.pnlRotate.Controls.Add(this.numShearY);
            this.pnlRotate.Controls.Add(this.lblX);
            this.pnlRotate.Controls.Add(this.numShearX);
            this.pnlRotate.Controls.Add(this.lblShearFactor);
            this.pnlRotate.Location = new System.Drawing.Point(619, 12);
            this.pnlRotate.Name = "pnlRotate";
            this.pnlRotate.Size = new System.Drawing.Size(251, 162);
            this.pnlRotate.TabIndex = 24;
            // 
            // lblY
            // 
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(3, 94);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(106, 38);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Shear Y:";
            this.lblY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblX
            // 
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(3, 56);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(106, 38);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "Shear X:";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShearFactor
            // 
            this.lblShearFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShearFactor.Location = new System.Drawing.Point(3, 6);
            this.lblShearFactor.Name = "lblShearFactor";
            this.lblShearFactor.Size = new System.Drawing.Size(243, 38);
            this.lblShearFactor.TabIndex = 0;
            this.lblShearFactor.Text = "Shear Factor";
            this.lblShearFactor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Text = "Image Transform Shear";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShearY)).EndInit();
            this.pnlRotate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.NumericUpDown numShearX;
        private System.Windows.Forms.NumericUpDown numShearY;
        private System.Windows.Forms.Panel pnlRotate;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblShearFactor;
    }
}


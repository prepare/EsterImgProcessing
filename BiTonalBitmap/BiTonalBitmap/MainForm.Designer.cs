namespace BiTonalBitmap
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
            this.pnlFilterControls = new System.Windows.Forms.Panel();
            this.lblLightColour = new System.Windows.Forms.Label();
            this.lblDarkColour = new System.Windows.Forms.Label();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.pnlDarkColour = new System.Windows.Forms.Panel();
            this.pnlLightColour = new System.Windows.Forms.Panel();
            this.lblThresholdValue = new System.Windows.Forms.Label();
            this.trcThreshold = new System.Windows.Forms.TrackBar();
            this.lblThreshold = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlFilterControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).BeginInit();
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
            this.picPreview.Size = new System.Drawing.Size(400, 400);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // pnlFilterControls
            // 
            this.pnlFilterControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterControls.Controls.Add(this.lblThreshold);
            this.pnlFilterControls.Controls.Add(this.lblThresholdValue);
            this.pnlFilterControls.Controls.Add(this.trcThreshold);
            this.pnlFilterControls.Controls.Add(this.pnlLightColour);
            this.pnlFilterControls.Controls.Add(this.pnlDarkColour);
            this.pnlFilterControls.Controls.Add(this.lblLightColour);
            this.pnlFilterControls.Controls.Add(this.lblDarkColour);
            this.pnlFilterControls.Location = new System.Drawing.Point(418, 12);
            this.pnlFilterControls.Name = "pnlFilterControls";
            this.pnlFilterControls.Size = new System.Drawing.Size(145, 400);
            this.pnlFilterControls.TabIndex = 14;
            // 
            // lblLightColour
            // 
            this.lblLightColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLightColour.Location = new System.Drawing.Point(6, 80);
            this.lblLightColour.Name = "lblLightColour";
            this.lblLightColour.Size = new System.Drawing.Size(131, 30);
            this.lblLightColour.TabIndex = 20;
            this.lblLightColour.Text = "Light Colour";
            this.lblLightColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDarkColour
            // 
            this.lblDarkColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDarkColour.Location = new System.Drawing.Point(6, 3);
            this.lblDarkColour.Name = "lblDarkColour";
            this.lblDarkColour.Size = new System.Drawing.Size(131, 30);
            this.lblDarkColour.TabIndex = 19;
            this.lblDarkColour.Text = "Dark Colour";
            this.lblDarkColour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 418);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(149, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(418, 418);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(145, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // pnlDarkColour
            // 
            this.pnlDarkColour.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlDarkColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDarkColour.Location = new System.Drawing.Point(6, 36);
            this.pnlDarkColour.Name = "pnlDarkColour";
            this.pnlDarkColour.Size = new System.Drawing.Size(131, 41);
            this.pnlDarkColour.TabIndex = 21;
            this.pnlDarkColour.Click += new System.EventHandler(this.ColourPanelClickEventHandler);
            // 
            // pnlLightColour
            // 
            this.pnlLightColour.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlLightColour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLightColour.Location = new System.Drawing.Point(6, 113);
            this.pnlLightColour.Name = "pnlLightColour";
            this.pnlLightColour.Size = new System.Drawing.Size(131, 41);
            this.pnlLightColour.TabIndex = 22;
            this.pnlLightColour.Click += new System.EventHandler(this.ColourPanelClickEventHandler);
            // 
            // lblThresholdValue
            // 
            this.lblThresholdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThresholdValue.Location = new System.Drawing.Point(6, 359);
            this.lblThresholdValue.Name = "lblThresholdValue";
            this.lblThresholdValue.Size = new System.Drawing.Size(131, 30);
            this.lblThresholdValue.TabIndex = 24;
            this.lblThresholdValue.Text = "380";
            this.lblThresholdValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.Color.LightGray;
            this.trcThreshold.Location = new System.Drawing.Point(59, 190);
            this.trcThreshold.Maximum = 765;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcThreshold.Size = new System.Drawing.Size(23, 166);
            this.trcThreshold.TabIndex = 23;
            this.trcThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcThreshold.Value = 380;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // lblThreshold
            // 
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(6, 157);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(131, 30);
            this.lblThreshold.TabIndex = 25;
            this.lblThreshold.Text = "Threshold";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(573, 472);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.pnlFilterControls);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bi-tonal Bitmap";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlFilterControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel pnlFilterControls;
        private System.Windows.Forms.Label lblLightColour;
        private System.Windows.Forms.Label lblDarkColour;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Panel pnlDarkColour;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label lblThresholdValue;
        private System.Windows.Forms.TrackBar trcThreshold;
        private System.Windows.Forms.Panel pnlLightColour;
    }
}


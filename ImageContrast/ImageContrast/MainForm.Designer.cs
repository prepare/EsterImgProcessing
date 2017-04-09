namespace ImageContrast
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
            this.lblContrast = new System.Windows.Forms.Label();
            this.lblContrastValue = new System.Windows.Forms.Label();
            this.trcThreshold = new System.Windows.Forms.TrackBar();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
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
            this.pnlFilterControls.Controls.Add(this.lblContrast);
            this.pnlFilterControls.Controls.Add(this.lblContrastValue);
            this.pnlFilterControls.Controls.Add(this.trcThreshold);
            this.pnlFilterControls.Location = new System.Drawing.Point(418, 12);
            this.pnlFilterControls.Name = "pnlFilterControls";
            this.pnlFilterControls.Size = new System.Drawing.Size(145, 400);
            this.pnlFilterControls.TabIndex = 14;
            // 
            // lblContrast
            // 
            this.lblContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrast.Location = new System.Drawing.Point(3, 9);
            this.lblContrast.Name = "lblContrast";
            this.lblContrast.Size = new System.Drawing.Size(134, 30);
            this.lblContrast.TabIndex = 25;
            this.lblContrast.Text = "Contrast";
            this.lblContrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContrastValue
            // 
            this.lblContrastValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrastValue.Location = new System.Drawing.Point(6, 362);
            this.lblContrastValue.Name = "lblContrastValue";
            this.lblContrastValue.Size = new System.Drawing.Size(131, 30);
            this.lblContrastValue.TabIndex = 24;
            this.lblContrastValue.Text = "0";
            this.lblContrastValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.Color.LightGray;
            this.trcThreshold.Location = new System.Drawing.Point(59, 42);
            this.trcThreshold.Maximum = 100;
            this.trcThreshold.Minimum = -100;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcThreshold.Size = new System.Drawing.Size(23, 314);
            this.trcThreshold.TabIndex = 23;
            this.trcThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.ThresholdValueChangedEventHandler);
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
            this.Text = "Image Contrast";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlFilterControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel pnlFilterControls;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Label lblContrast;
        private System.Windows.Forms.Label lblContrastValue;
        private System.Windows.Forms.TrackBar trcThreshold;
    }
}


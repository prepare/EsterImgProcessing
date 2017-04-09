namespace ImageCartoonEffect
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
            this.cmbSmoothingFilter = new System.Windows.Forms.ComboBox();
            this.lblSmoothingFilter = new System.Windows.Forms.Label();
            this.trcThreshold = new System.Windows.Forms.TrackBar();
            this.lblThresholdInfo = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.pnlThreshold = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).BeginInit();
            this.pnlThreshold.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.btnOpenOriginal.Location = new System.Drawing.Point(618, 514);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(228, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(618, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(228, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbSmoothingFilter
            // 
            this.cmbSmoothingFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmoothingFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSmoothingFilter.FormattingEnabled = true;
            this.cmbSmoothingFilter.Location = new System.Drawing.Point(7, 36);
            this.cmbSmoothingFilter.Name = "cmbSmoothingFilter";
            this.cmbSmoothingFilter.Size = new System.Drawing.Size(213, 32);
            this.cmbSmoothingFilter.TabIndex = 20;
            this.cmbSmoothingFilter.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblSmoothingFilter
            // 
            this.lblSmoothingFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothingFilter.Location = new System.Drawing.Point(3, 3);
            this.lblSmoothingFilter.Name = "lblSmoothingFilter";
            this.lblSmoothingFilter.Size = new System.Drawing.Size(217, 30);
            this.lblSmoothingFilter.TabIndex = 26;
            this.lblSmoothingFilter.Text = "Smoothing Filter";
            this.lblSmoothingFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.SystemColors.Control;
            this.trcThreshold.Location = new System.Drawing.Point(7, 33);
            this.trcThreshold.Maximum = 256;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Size = new System.Drawing.Size(213, 30);
            this.trcThreshold.TabIndex = 27;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblThresholdInfo
            // 
            this.lblThresholdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThresholdInfo.Location = new System.Drawing.Point(3, 0);
            this.lblThresholdInfo.Name = "lblThresholdInfo";
            this.lblThresholdInfo.Size = new System.Drawing.Size(112, 30);
            this.lblThresholdInfo.TabIndex = 28;
            this.lblThresholdInfo.Text = "Threshold:";
            this.lblThresholdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreshold
            // 
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(142, 0);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(74, 30);
            this.lblThreshold.TabIndex = 29;
            this.lblThreshold.Text = "0";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlThreshold
            // 
            this.pnlThreshold.BackColor = System.Drawing.Color.Silver;
            this.pnlThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThreshold.Controls.Add(this.lblThresholdInfo);
            this.pnlThreshold.Controls.Add(this.lblThreshold);
            this.pnlThreshold.Controls.Add(this.trcThreshold);
            this.pnlThreshold.Location = new System.Drawing.Point(618, 94);
            this.pnlThreshold.Name = "pnlThreshold";
            this.pnlThreshold.Size = new System.Drawing.Size(228, 76);
            this.pnlThreshold.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSmoothingFilter);
            this.panel1.Controls.Add(this.cmbSmoothingFilter);
            this.panel1.Location = new System.Drawing.Point(618, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 76);
            this.panel1.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(853, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlThreshold);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Cartoon Effect";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            this.pnlThreshold.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbSmoothingFilter;
        private System.Windows.Forms.Label lblSmoothingFilter;
        private System.Windows.Forms.TrackBar trcThreshold;
        private System.Windows.Forms.Label lblThresholdInfo;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Panel pnlThreshold;
        private System.Windows.Forms.Panel panel1;
    }
}


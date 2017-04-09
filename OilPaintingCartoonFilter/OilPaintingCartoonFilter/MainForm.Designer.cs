namespace OilPaintingCartoonFilter
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
            this.cmbFilterSize = new System.Windows.Forms.ComboBox();
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.pnlBlur = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numIntensityLevels = new System.Windows.Forms.NumericUpDown();
            this.lblIntensityLevels = new System.Windows.Forms.Label();
            this.pnlThreshold = new System.Windows.Forms.Panel();
            this.lblThresholdInfo = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.trcThreshold = new System.Windows.Forms.TrackBar();
            this.chkCartoonFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlBlur.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIntensityLevels)).BeginInit();
            this.pnlThreshold.SuspendLayout();
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
            this.btnOpenOriginal.Size = new System.Drawing.Size(178, 46);
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
            this.btnSaveNewImage.Size = new System.Drawing.Size(178, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbFilterSize
            // 
            this.cmbFilterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterSize.FormattingEnabled = true;
            this.cmbFilterSize.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15"});
            this.cmbFilterSize.Location = new System.Drawing.Point(7, 36);
            this.cmbFilterSize.Name = "cmbFilterSize";
            this.cmbFilterSize.Size = new System.Drawing.Size(160, 32);
            this.cmbFilterSize.TabIndex = 20;
            this.cmbFilterSize.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSize.Location = new System.Drawing.Point(3, 3);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(164, 30);
            this.lblFilterSize.TabIndex = 26;
            this.lblFilterSize.Text = "Filter Size";
            this.lblFilterSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBlur
            // 
            this.pnlBlur.BackColor = System.Drawing.Color.Silver;
            this.pnlBlur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlur.Controls.Add(this.lblFilterSize);
            this.pnlBlur.Controls.Add(this.cmbFilterSize);
            this.pnlBlur.Location = new System.Drawing.Point(618, 12);
            this.pnlBlur.Name = "pnlBlur";
            this.pnlBlur.Size = new System.Drawing.Size(178, 76);
            this.pnlBlur.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numIntensityLevels);
            this.panel1.Controls.Add(this.lblIntensityLevels);
            this.panel1.Location = new System.Drawing.Point(618, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 76);
            this.panel1.TabIndex = 35;
            // 
            // numIntensityLevels
            // 
            this.numIntensityLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numIntensityLevels.Location = new System.Drawing.Point(7, 36);
            this.numIntensityLevels.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numIntensityLevels.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numIntensityLevels.Name = "numIntensityLevels";
            this.numIntensityLevels.Size = new System.Drawing.Size(160, 31);
            this.numIntensityLevels.TabIndex = 27;
            this.numIntensityLevels.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numIntensityLevels.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numIntensityLevels.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblIntensityLevels
            // 
            this.lblIntensityLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntensityLevels.Location = new System.Drawing.Point(3, 3);
            this.lblIntensityLevels.Name = "lblIntensityLevels";
            this.lblIntensityLevels.Size = new System.Drawing.Size(164, 30);
            this.lblIntensityLevels.TabIndex = 26;
            this.lblIntensityLevels.Text = "Intensity Levels";
            this.lblIntensityLevels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlThreshold
            // 
            this.pnlThreshold.BackColor = System.Drawing.Color.Silver;
            this.pnlThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThreshold.Controls.Add(this.lblThresholdInfo);
            this.pnlThreshold.Controls.Add(this.lblThreshold);
            this.pnlThreshold.Controls.Add(this.trcThreshold);
            this.pnlThreshold.Location = new System.Drawing.Point(618, 176);
            this.pnlThreshold.Name = "pnlThreshold";
            this.pnlThreshold.Size = new System.Drawing.Size(178, 76);
            this.pnlThreshold.TabIndex = 36;
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
            this.lblThreshold.Location = new System.Drawing.Point(121, 0);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(56, 30);
            this.lblThreshold.TabIndex = 29;
            this.lblThreshold.Text = "50";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.SystemColors.Control;
            this.trcThreshold.Location = new System.Drawing.Point(7, 33);
            this.trcThreshold.Maximum = 200;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Size = new System.Drawing.Size(160, 30);
            this.trcThreshold.TabIndex = 27;
            this.trcThreshold.Value = 50;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // chkCartoonFilter
            // 
            this.chkCartoonFilter.AutoSize = true;
            this.chkCartoonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCartoonFilter.Location = new System.Drawing.Point(618, 258);
            this.chkCartoonFilter.Name = "chkCartoonFilter";
            this.chkCartoonFilter.Size = new System.Drawing.Size(175, 29);
            this.chkCartoonFilter.TabIndex = 37;
            this.chkCartoonFilter.Text = "Cartoon Filter";
            this.chkCartoonFilter.UseVisualStyleBackColor = true;
            this.chkCartoonFilter.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(803, 622);
            this.Controls.Add(this.chkCartoonFilter);
            this.Controls.Add(this.pnlThreshold);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBlur);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oil Painting Cartoon Filter";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlBlur.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numIntensityLevels)).EndInit();
            this.pnlThreshold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbFilterSize;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.Panel pnlBlur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numIntensityLevels;
        private System.Windows.Forms.Label lblIntensityLevels;
        private System.Windows.Forms.Panel pnlThreshold;
        private System.Windows.Forms.Label lblThresholdInfo;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TrackBar trcThreshold;
        private System.Windows.Forms.CheckBox chkCartoonFilter;
    }
}


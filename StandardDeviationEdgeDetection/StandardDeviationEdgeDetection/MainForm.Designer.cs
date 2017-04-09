namespace SoftwareByDefault.StandardDeviationEdgeDetection
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
            this.lblVarianceFactor = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.chkGrayscale = new System.Windows.Forms.CheckBox();
            this.numVarianceFactor = new System.Windows.Forms.NumericUpDown();
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.cmbFilterSize = new System.Windows.Forms.ComboBox();
            this.lblProcessTimeInfo = new System.Windows.Forms.Label();
            this.lblProcessDuration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarianceFactor)).BeginInit();
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
            // lblVarianceFactor
            // 
            this.lblVarianceFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarianceFactor.Location = new System.Drawing.Point(-1, 37);
            this.lblVarianceFactor.Name = "lblVarianceFactor";
            this.lblVarianceFactor.Size = new System.Drawing.Size(94, 48);
            this.lblVarianceFactor.TabIndex = 26;
            this.lblVarianceFactor.Text = "Variance Factor";
            this.lblVarianceFactor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.Silver;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.chkGrayscale);
            this.pnlFilters.Controls.Add(this.numVarianceFactor);
            this.pnlFilters.Controls.Add(this.lblFilterSize);
            this.pnlFilters.Controls.Add(this.cmbFilterSize);
            this.pnlFilters.Controls.Add(this.lblVarianceFactor);
            this.pnlFilters.Location = new System.Drawing.Point(618, 12);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(228, 121);
            this.pnlFilters.TabIndex = 34;
            // 
            // chkGrayscale
            // 
            this.chkGrayscale.AutoSize = true;
            this.chkGrayscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.chkGrayscale.Location = new System.Drawing.Point(110, 82);
            this.chkGrayscale.Name = "chkGrayscale";
            this.chkGrayscale.Size = new System.Drawing.Size(121, 28);
            this.chkGrayscale.TabIndex = 30;
            this.chkGrayscale.Text = "Grayscale";
            this.chkGrayscale.UseVisualStyleBackColor = true;
            this.chkGrayscale.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // numVarianceFactor
            // 
            this.numVarianceFactor.DecimalPlaces = 1;
            this.numVarianceFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.numVarianceFactor.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numVarianceFactor.Location = new System.Drawing.Point(110, 47);
            this.numVarianceFactor.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numVarianceFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numVarianceFactor.Name = "numVarianceFactor";
            this.numVarianceFactor.Size = new System.Drawing.Size(112, 29);
            this.numVarianceFactor.TabIndex = 29;
            this.numVarianceFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numVarianceFactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numVarianceFactor.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSize.Location = new System.Drawing.Point(-1, 2);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(105, 30);
            this.lblFilterSize.TabIndex = 28;
            this.lblFilterSize.Text = "Filter Size";
            this.lblFilterSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFilterSize
            // 
            this.cmbFilterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterSize.FormattingEnabled = true;
            this.cmbFilterSize.Items.AddRange(new object[] {
            "3x3",
            "5x5",
            "7x7",
            "9x9",
            "11x11"});
            this.cmbFilterSize.Location = new System.Drawing.Point(110, 2);
            this.cmbFilterSize.Name = "cmbFilterSize";
            this.cmbFilterSize.Size = new System.Drawing.Size(112, 32);
            this.cmbFilterSize.TabIndex = 27;
            this.cmbFilterSize.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblProcessTimeInfo
            // 
            this.lblProcessTimeInfo.AutoSize = true;
            this.lblProcessTimeInfo.Location = new System.Drawing.Point(615, 136);
            this.lblProcessTimeInfo.Name = "lblProcessTimeInfo";
            this.lblProcessTimeInfo.Size = new System.Drawing.Size(134, 13);
            this.lblProcessTimeInfo.TabIndex = 35;
            this.lblProcessTimeInfo.Text = "Duration of last opperation:";
            // 
            // lblProcessDuration
            // 
            this.lblProcessDuration.AutoSize = true;
            this.lblProcessDuration.Location = new System.Drawing.Point(755, 136);
            this.lblProcessDuration.Name = "lblProcessDuration";
            this.lblProcessDuration.Size = new System.Drawing.Size(27, 13);
            this.lblProcessDuration.TabIndex = 36;
            this.lblProcessDuration.Text = "N/A";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(853, 622);
            this.Controls.Add(this.lblProcessDuration);
            this.Controls.Add(this.lblProcessTimeInfo);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Standard Deviation Edge Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVarianceFactor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Label lblVarianceFactor;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.ComboBox cmbFilterSize;
        private System.Windows.Forms.Label lblProcessTimeInfo;
        private System.Windows.Forms.Label lblProcessDuration;
        private System.Windows.Forms.NumericUpDown numVarianceFactor;
        private System.Windows.Forms.CheckBox chkGrayscale;
    }
}


namespace BitmapArgbSwapping
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
            this.lblOriginalImage = new System.Windows.Forms.Label();
            this.lblNewImage = new System.Windows.Forms.Label();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.chkInvertColours = new System.Windows.Forms.CheckBox();
            this.chkHalfColours = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOriginalImage
            // 
            this.lblOriginalImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalImage.Location = new System.Drawing.Point(12, 9);
            this.lblOriginalImage.Name = "lblOriginalImage";
            this.lblOriginalImage.Size = new System.Drawing.Size(400, 34);
            this.lblOriginalImage.TabIndex = 2;
            this.lblOriginalImage.Text = "Original Image";
            this.lblOriginalImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewImage
            // 
            this.lblNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewImage.Location = new System.Drawing.Point(426, 9);
            this.lblNewImage.Name = "lblNewImage";
            this.lblNewImage.Size = new System.Drawing.Size(400, 34);
            this.lblNewImage.TabIndex = 4;
            this.lblNewImage.Text = "New Image";
            this.lblNewImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 458);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(149, 46);
            this.btnOpenOriginal.TabIndex = 5;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(682, 458);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(149, 46);
            this.btnSaveNewImage.TabIndex = 6;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(431, 460);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(210, 21);
            this.cmbFilterType.TabIndex = 7;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // picSource
            // 
            this.picSource.BackColor = System.Drawing.Color.Silver;
            this.picSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picSource.Location = new System.Drawing.Point(12, 52);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(400, 400);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSource.TabIndex = 8;
            this.picSource.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.Silver;
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picResult.Location = new System.Drawing.Point(431, 52);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(400, 400);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 9;
            this.picResult.TabStop = false;
            // 
            // chkInvertColours
            // 
            this.chkInvertColours.AutoSize = true;
            this.chkInvertColours.Location = new System.Drawing.Point(431, 487);
            this.chkInvertColours.Name = "chkInvertColours";
            this.chkInvertColours.Size = new System.Drawing.Size(91, 17);
            this.chkInvertColours.TabIndex = 10;
            this.chkInvertColours.Text = "Invert Colours";
            this.chkInvertColours.UseVisualStyleBackColor = true;
            this.chkInvertColours.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // chkHalfColours
            // 
            this.chkHalfColours.AutoSize = true;
            this.chkHalfColours.Location = new System.Drawing.Point(528, 487);
            this.chkHalfColours.Name = "chkHalfColours";
            this.chkHalfColours.Size = new System.Drawing.Size(113, 17);
            this.chkHalfColours.TabIndex = 11;
            this.chkHalfColours.Text = "Swap Half Colours";
            this.chkHalfColours.UseVisualStyleBackColor = true;
            this.chkHalfColours.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(847, 514);
            this.Controls.Add(this.chkHalfColours);
            this.Controls.Add(this.chkInvertColours);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picSource);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.lblNewImage);
            this.Controls.Add(this.lblOriginalImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap ARGB Swapping";
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOriginalImage;
        private System.Windows.Forms.Label lblNewImage;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.CheckBox chkInvertColours;
        private System.Windows.Forms.CheckBox chkHalfColours;
    }
}


namespace BitmapPixelManipulation
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
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picSource = new System.Windows.Forms.PictureBox();
            this.lblNewImage = new System.Windows.Forms.Label();
            this.lblOriginalImage = new System.Windows.Forms.Label();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.lblFixedValue = new System.Windows.Forms.Label();
            this.trcFixedValue = new System.Windows.Forms.TrackBar();
            this.chkSwapColours = new System.Windows.Forms.CheckBox();
            this.chkFlipPixels = new System.Windows.Forms.CheckBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.chkInvertColours = new System.Windows.Forms.CheckBox();
            this.cmbInvertColoursType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcFixedValue)).BeginInit();
            this.SuspendLayout();
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
            this.picResult.TabIndex = 13;
            this.picResult.TabStop = false;
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
            this.picSource.TabIndex = 12;
            this.picSource.TabStop = false;
            // 
            // lblNewImage
            // 
            this.lblNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewImage.Location = new System.Drawing.Point(426, 9);
            this.lblNewImage.Name = "lblNewImage";
            this.lblNewImage.Size = new System.Drawing.Size(400, 34);
            this.lblNewImage.TabIndex = 11;
            this.lblNewImage.Text = "New Image";
            this.lblNewImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOriginalImage
            // 
            this.lblOriginalImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalImage.Location = new System.Drawing.Point(12, 9);
            this.lblOriginalImage.Name = "lblOriginalImage";
            this.lblOriginalImage.Size = new System.Drawing.Size(400, 34);
            this.lblOriginalImage.TabIndex = 10;
            this.lblOriginalImage.Text = "Original Image";
            this.lblOriginalImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(837, 458);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(170, 46);
            this.btnSaveNewImage.TabIndex = 15;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 458);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(149, 46);
            this.btnOpenOriginal.TabIndex = 14;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.cmbInvertColoursType);
            this.pnlFilters.Controls.Add(this.chkInvertColours);
            this.pnlFilters.Controls.Add(this.cmbFilterType);
            this.pnlFilters.Controls.Add(this.lblFixedValue);
            this.pnlFilters.Controls.Add(this.trcFixedValue);
            this.pnlFilters.Controls.Add(this.chkSwapColours);
            this.pnlFilters.Controls.Add(this.chkFlipPixels);
            this.pnlFilters.Location = new System.Drawing.Point(837, 52);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(170, 400);
            this.pnlFilters.TabIndex = 16;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(5, 107);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(159, 21);
            this.cmbFilterType.TabIndex = 8;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.FilterControlsValueChangedEventHandler);
            // 
            // lblFixedValue
            // 
            this.lblFixedValue.Location = new System.Drawing.Point(5, 131);
            this.lblFixedValue.Name = "lblFixedValue";
            this.lblFixedValue.Size = new System.Drawing.Size(159, 26);
            this.lblFixedValue.TabIndex = 4;
            this.lblFixedValue.Text = "Fixed Value: 0";
            this.lblFixedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcFixedValue
            // 
            this.trcFixedValue.AutoSize = false;
            this.trcFixedValue.BackColor = System.Drawing.Color.LightGray;
            this.trcFixedValue.Location = new System.Drawing.Point(56, 160);
            this.trcFixedValue.Maximum = 256;
            this.trcFixedValue.Name = "trcFixedValue";
            this.trcFixedValue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcFixedValue.Size = new System.Drawing.Size(46, 227);
            this.trcFixedValue.TabIndex = 3;
            this.trcFixedValue.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcFixedValue.ValueChanged += new System.EventHandler(this.FilterControlsValueChangedEventHandler);
            // 
            // chkSwapColours
            // 
            this.chkSwapColours.AutoSize = true;
            this.chkSwapColours.Location = new System.Drawing.Point(17, 84);
            this.chkSwapColours.Name = "chkSwapColours";
            this.chkSwapColours.Size = new System.Drawing.Size(91, 17);
            this.chkSwapColours.TabIndex = 1;
            this.chkSwapColours.Text = "Swap Colours";
            this.chkSwapColours.UseVisualStyleBackColor = true;
            this.chkSwapColours.CheckedChanged += new System.EventHandler(this.FilterControlsValueChangedEventHandler);
            // 
            // chkFlipPixels
            // 
            this.chkFlipPixels.AutoSize = true;
            this.chkFlipPixels.Location = new System.Drawing.Point(17, 9);
            this.chkFlipPixels.Name = "chkFlipPixels";
            this.chkFlipPixels.Size = new System.Drawing.Size(72, 17);
            this.chkFlipPixels.TabIndex = 0;
            this.chkFlipPixels.Text = "Flip Pixels";
            this.chkFlipPixels.UseVisualStyleBackColor = true;
            this.chkFlipPixels.CheckedChanged += new System.EventHandler(this.FilterControlsValueChangedEventHandler);
            // 
            // lblFilter
            // 
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(832, 9);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(175, 34);
            this.lblFilter.TabIndex = 17;
            this.lblFilter.Text = "Filter";
            this.lblFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkInvertColours
            // 
            this.chkInvertColours.AutoSize = true;
            this.chkInvertColours.Location = new System.Drawing.Point(17, 32);
            this.chkInvertColours.Name = "chkInvertColours";
            this.chkInvertColours.Size = new System.Drawing.Size(91, 17);
            this.chkInvertColours.TabIndex = 9;
            this.chkInvertColours.Text = "Invert Colours";
            this.chkInvertColours.UseVisualStyleBackColor = true;
            this.chkInvertColours.CheckedChanged += new System.EventHandler(this.FilterControlsValueChangedEventHandler);
            // 
            // cmbInvertColoursType
            // 
            this.cmbInvertColoursType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInvertColoursType.FormattingEnabled = true;
            this.cmbInvertColoursType.Location = new System.Drawing.Point(5, 55);
            this.cmbInvertColoursType.Name = "cmbInvertColoursType";
            this.cmbInvertColoursType.Size = new System.Drawing.Size(159, 21);
            this.cmbInvertColoursType.TabIndex = 10;
            this.cmbInvertColoursType.SelectedIndexChanged += new System.EventHandler(this.FilterControlsValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1020, 516);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picSource);
            this.Controls.Add(this.lblNewImage);
            this.Controls.Add(this.lblOriginalImage);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitmap Pixel Manipulation";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcFixedValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.Label lblNewImage;
        private System.Windows.Forms.Label lblOriginalImage;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.CheckBox chkSwapColours;
        private System.Windows.Forms.CheckBox chkFlipPixels;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Label lblFixedValue;
        private System.Windows.Forms.TrackBar trcFixedValue;
        private System.Windows.Forms.ComboBox cmbInvertColoursType;
        private System.Windows.Forms.CheckBox chkInvertColours;
    }
}


namespace ImageAbstractColourFilter
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
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbFilterSize = new System.Windows.Forms.ComboBox();
            this.chkR = new System.Windows.Forms.CheckBox();
            this.chkG = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.lblColorShiftType = new System.Windows.Forms.Label();
            this.cmbColorShiftType = new System.Windows.Forms.ComboBox();
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.cmbEdgeTracing = new System.Windows.Forms.ComboBox();
            this.lblEdgeTracing = new System.Windows.Forms.Label();
            this.lblEdgeThreshold = new System.Windows.Forms.Label();
            this.numEdgeThreshold = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdgeThreshold)).BeginInit();
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
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImage.Location = new System.Drawing.Point(618, 510);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(172, 46);
            this.btnLoadImage.TabIndex = 15;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(618, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(172, 46);
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
            "None",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "17"});
            this.cmbFilterSize.Location = new System.Drawing.Point(618, 158);
            this.cmbFilterSize.Name = "cmbFilterSize";
            this.cmbFilterSize.Size = new System.Drawing.Size(172, 32);
            this.cmbFilterSize.TabIndex = 20;
            this.cmbFilterSize.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // chkR
            // 
            this.chkR.AutoSize = true;
            this.chkR.Checked = true;
            this.chkR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkR.Location = new System.Drawing.Point(618, 12);
            this.chkR.Name = "chkR";
            this.chkR.Size = new System.Drawing.Size(73, 29);
            this.chkR.TabIndex = 21;
            this.chkR.Text = "Red";
            this.chkR.UseVisualStyleBackColor = true;
            this.chkR.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // chkG
            // 
            this.chkG.AutoSize = true;
            this.chkG.Checked = true;
            this.chkG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkG.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkG.Location = new System.Drawing.Point(618, 47);
            this.chkG.Name = "chkG";
            this.chkG.Size = new System.Drawing.Size(95, 29);
            this.chkG.TabIndex = 22;
            this.chkG.Text = "Green";
            this.chkG.UseVisualStyleBackColor = true;
            this.chkG.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Checked = true;
            this.chkB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB.Location = new System.Drawing.Point(618, 82);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(78, 29);
            this.chkB.TabIndex = 23;
            this.chkB.Text = "Blue";
            this.chkB.UseVisualStyleBackColor = true;
            this.chkB.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblColorShiftType
            // 
            this.lblColorShiftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorShiftType.Location = new System.Drawing.Point(618, 193);
            this.lblColorShiftType.Name = "lblColorShiftType";
            this.lblColorShiftType.Size = new System.Drawing.Size(172, 35);
            this.lblColorShiftType.TabIndex = 24;
            this.lblColorShiftType.Text = "Colour Shift";
            this.lblColorShiftType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbColorShiftType
            // 
            this.cmbColorShiftType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorShiftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorShiftType.FormattingEnabled = true;
            this.cmbColorShiftType.Location = new System.Drawing.Point(618, 231);
            this.cmbColorShiftType.Name = "cmbColorShiftType";
            this.cmbColorShiftType.Size = new System.Drawing.Size(172, 32);
            this.cmbColorShiftType.TabIndex = 25;
            this.cmbColorShiftType.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSize.Location = new System.Drawing.Point(618, 114);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(172, 41);
            this.lblFilterSize.TabIndex = 26;
            this.lblFilterSize.Text = "Filter Size";
            this.lblFilterSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbEdgeTracing
            // 
            this.cmbEdgeTracing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdgeTracing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeTracing.FormattingEnabled = true;
            this.cmbEdgeTracing.Location = new System.Drawing.Point(618, 304);
            this.cmbEdgeTracing.Name = "cmbEdgeTracing";
            this.cmbEdgeTracing.Size = new System.Drawing.Size(172, 32);
            this.cmbEdgeTracing.TabIndex = 28;
            this.cmbEdgeTracing.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblEdgeTracing
            // 
            this.lblEdgeTracing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeTracing.Location = new System.Drawing.Point(618, 266);
            this.lblEdgeTracing.Name = "lblEdgeTracing";
            this.lblEdgeTracing.Size = new System.Drawing.Size(172, 35);
            this.lblEdgeTracing.TabIndex = 27;
            this.lblEdgeTracing.Text = "Edge Tracing";
            this.lblEdgeTracing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdgeThreshold
            // 
            this.lblEdgeThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeThreshold.Location = new System.Drawing.Point(618, 339);
            this.lblEdgeThreshold.Name = "lblEdgeThreshold";
            this.lblEdgeThreshold.Size = new System.Drawing.Size(172, 39);
            this.lblEdgeThreshold.TabIndex = 29;
            this.lblEdgeThreshold.Text = "Edge Threshold";
            this.lblEdgeThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numEdgeThreshold
            // 
            this.numEdgeThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEdgeThreshold.Location = new System.Drawing.Point(625, 381);
            this.numEdgeThreshold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numEdgeThreshold.Name = "numEdgeThreshold";
            this.numEdgeThreshold.Size = new System.Drawing.Size(165, 31);
            this.numEdgeThreshold.TabIndex = 30;
            this.numEdgeThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEdgeThreshold.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numEdgeThreshold.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(799, 622);
            this.Controls.Add(this.numEdgeThreshold);
            this.Controls.Add(this.lblEdgeThreshold);
            this.Controls.Add(this.cmbEdgeTracing);
            this.Controls.Add(this.lblEdgeTracing);
            this.Controls.Add(this.lblFilterSize);
            this.Controls.Add(this.cmbColorShiftType);
            this.Controls.Add(this.lblColorShiftType);
            this.Controls.Add(this.chkB);
            this.Controls.Add(this.chkG);
            this.Controls.Add(this.chkR);
            this.Controls.Add(this.cmbFilterSize);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Abstract Colour Filter ";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdgeThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbFilterSize;
        private System.Windows.Forms.CheckBox chkR;
        private System.Windows.Forms.CheckBox chkG;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.Label lblColorShiftType;
        private System.Windows.Forms.ComboBox cmbColorShiftType;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.ComboBox cmbEdgeTracing;
        private System.Windows.Forms.Label lblEdgeTracing;
        private System.Windows.Forms.Label lblEdgeThreshold;
        private System.Windows.Forms.NumericUpDown numEdgeThreshold;
    }
}


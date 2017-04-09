namespace ImageBoundaryExtraction
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
            this.chkR = new System.Windows.Forms.CheckBox();
            this.chkG = new System.Windows.Forms.CheckBox();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.pnlSE = new System.Windows.Forms.Panel();
            this.lblSC = new System.Windows.Forms.Label();
            this.chkLivePreview = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
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
            this.btnOpenOriginal.Location = new System.Drawing.Point(620, 514);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(253, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(620, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(253, 46);
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
            this.cmbFilterSize.Location = new System.Drawing.Point(737, 98);
            this.cmbFilterSize.Name = "cmbFilterSize";
            this.cmbFilterSize.Size = new System.Drawing.Size(139, 32);
            this.cmbFilterSize.TabIndex = 20;
            this.cmbFilterSize.SelectedIndexChanged += new System.EventHandler(this.FilterSizeValueChangedEventHandler);
            // 
            // chkR
            // 
            this.chkR.AutoSize = true;
            this.chkR.Checked = true;
            this.chkR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkR.Location = new System.Drawing.Point(618, 144);
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
            this.chkG.Location = new System.Drawing.Point(697, 144);
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
            this.chkB.Location = new System.Drawing.Point(798, 144);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(78, 29);
            this.chkB.TabIndex = 23;
            this.chkB.Text = "Blue";
            this.chkB.UseVisualStyleBackColor = true;
            this.chkB.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSize.Location = new System.Drawing.Point(616, 93);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(111, 41);
            this.lblFilterSize.TabIndex = 26;
            this.lblFilterSize.Text = "Filter Size";
            this.lblFilterSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFilterType
            // 
            this.lblFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterType.Location = new System.Drawing.Point(616, 12);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(260, 41);
            this.lblFilterType.TabIndex = 32;
            this.lblFilterType.Text = "Filter Type";
            this.lblFilterType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(620, 60);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(256, 32);
            this.cmbFilterType.TabIndex = 31;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // pnlSE
            // 
            this.pnlSE.AutoScroll = true;
            this.pnlSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSE.Location = new System.Drawing.Point(620, 218);
            this.pnlSE.Name = "pnlSE";
            this.pnlSE.Size = new System.Drawing.Size(256, 256);
            this.pnlSE.TabIndex = 33;
            // 
            // lblSC
            // 
            this.lblSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.Location = new System.Drawing.Point(620, 176);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(256, 38);
            this.lblSC.TabIndex = 34;
            this.lblSC.Text = "Structuring Element";
            this.lblSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkLivePreview
            // 
            this.chkLivePreview.AutoSize = true;
            this.chkLivePreview.Checked = true;
            this.chkLivePreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLivePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLivePreview.Location = new System.Drawing.Point(618, 478);
            this.chkLivePreview.Name = "chkLivePreview";
            this.chkLivePreview.Size = new System.Drawing.Size(165, 29);
            this.chkLivePreview.TabIndex = 35;
            this.chkLivePreview.Text = "Live Preview";
            this.chkLivePreview.UseVisualStyleBackColor = true;
            this.chkLivePreview.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(883, 625);
            this.Controls.Add(this.chkLivePreview);
            this.Controls.Add(this.lblSC);
            this.Controls.Add(this.pnlSE);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.lblFilterSize);
            this.Controls.Add(this.chkB);
            this.Controls.Add(this.chkG);
            this.Controls.Add(this.chkR);
            this.Controls.Add(this.cmbFilterSize);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Boundary Extraction ";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbFilterSize;
        private System.Windows.Forms.CheckBox chkR;
        private System.Windows.Forms.CheckBox chkG;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Panel pnlSE;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.CheckBox chkLivePreview;
    }
}


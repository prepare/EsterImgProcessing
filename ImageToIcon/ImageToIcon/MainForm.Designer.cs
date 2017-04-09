namespace ImageToIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.picSource = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSaveIcon = new System.Windows.Forms.Button();
            this.cmbIconSize = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            this.SuspendLayout();
            // 
            // picSource
            // 
            this.picSource.BackColor = System.Drawing.Color.Silver;
            this.picSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picSource.Location = new System.Drawing.Point(12, 12);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(400, 400);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSource.TabIndex = 1;
            this.picSource.TabStop = false;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 418);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(91, 23);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnSaveIcon
            // 
            this.btnSaveIcon.Location = new System.Drawing.Point(321, 418);
            this.btnSaveIcon.Name = "btnSaveIcon";
            this.btnSaveIcon.Size = new System.Drawing.Size(91, 23);
            this.btnSaveIcon.TabIndex = 3;
            this.btnSaveIcon.Text = "Save Icon";
            this.btnSaveIcon.UseVisualStyleBackColor = true;
            this.btnSaveIcon.Click += new System.EventHandler(this.btnSaveIcon_Click);
            // 
            // cmbIconSize
            // 
            this.cmbIconSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIconSize.FormattingEnabled = true;
            this.cmbIconSize.Location = new System.Drawing.Point(156, 420);
            this.cmbIconSize.Name = "cmbIconSize";
            this.cmbIconSize.Size = new System.Drawing.Size(159, 21);
            this.cmbIconSize.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(431, 454);
            this.Controls.Add(this.cmbIconSize);
            this.Controls.Add(this.btnSaveIcon);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.picSource);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image to Icon Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSaveIcon;
        private System.Windows.Forms.ComboBox cmbIconSize;
    }
}


namespace ImageArithmetic
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
            this.btnLoadPreview2 = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbBlendType = new System.Windows.Forms.ComboBox();
            this.picPreview1 = new System.Windows.Forms.PictureBox();
            this.picPreview2 = new System.Windows.Forms.PictureBox();
            this.btnLoadPreview1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(217, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(500, 500);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnLoadPreview2
            // 
            this.btnLoadPreview2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPreview2.Location = new System.Drawing.Point(11, 474);
            this.btnLoadPreview2.Name = "btnLoadPreview2";
            this.btnLoadPreview2.Size = new System.Drawing.Size(200, 38);
            this.btnLoadPreview2.TabIndex = 15;
            this.btnLoadPreview2.Text = "Load Image";
            this.btnLoadPreview2.UseVisualStyleBackColor = true;
            this.btnLoadPreview2.Click += new System.EventHandler(this.LoadImageButtonClickedEventHandler);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(517, 518);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(200, 43);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbBlendType
            // 
            this.cmbBlendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlendType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlendType.FormattingEnabled = true;
            this.cmbBlendType.Location = new System.Drawing.Point(217, 521);
            this.cmbBlendType.Name = "cmbBlendType";
            this.cmbBlendType.Size = new System.Drawing.Size(188, 37);
            this.cmbBlendType.TabIndex = 23;
            this.cmbBlendType.SelectedIndexChanged += new System.EventHandler(this.BlendTypeSelectedIndexChangedEventHandler);
            // 
            // picPreview1
            // 
            this.picPreview1.BackColor = System.Drawing.Color.Silver;
            this.picPreview1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview1.Location = new System.Drawing.Point(11, 12);
            this.picPreview1.Name = "picPreview1";
            this.picPreview1.Size = new System.Drawing.Size(200, 200);
            this.picPreview1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview1.TabIndex = 18;
            this.picPreview1.TabStop = false;
            // 
            // picPreview2
            // 
            this.picPreview2.BackColor = System.Drawing.Color.Silver;
            this.picPreview2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview2.Location = new System.Drawing.Point(11, 268);
            this.picPreview2.Name = "picPreview2";
            this.picPreview2.Size = new System.Drawing.Size(200, 200);
            this.picPreview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview2.TabIndex = 19;
            this.picPreview2.TabStop = false;
            // 
            // btnLoadPreview1
            // 
            this.btnLoadPreview1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadPreview1.Location = new System.Drawing.Point(11, 220);
            this.btnLoadPreview1.Name = "btnLoadPreview1";
            this.btnLoadPreview1.Size = new System.Drawing.Size(200, 38);
            this.btnLoadPreview1.TabIndex = 20;
            this.btnLoadPreview1.Text = "Load Image";
            this.btnLoadPreview1.UseVisualStyleBackColor = true;
            this.btnLoadPreview1.Click += new System.EventHandler(this.LoadImageButtonClickedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(729, 568);
            this.Controls.Add(this.btnLoadPreview1);
            this.Controls.Add(this.picPreview2);
            this.Controls.Add(this.cmbBlendType);
            this.Controls.Add(this.picPreview1);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnLoadPreview2);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Arithmetic";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnLoadPreview2;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbBlendType;
        private System.Windows.Forms.PictureBox picPreview1;
        private System.Windows.Forms.PictureBox picPreview2;
        private System.Windows.Forms.Button btnLoadPreview1;
    }
}


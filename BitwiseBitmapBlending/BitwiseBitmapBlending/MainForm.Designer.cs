namespace BitmapShading
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
            this.btnLoadBlendImage = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.pnlFilterControls = new System.Windows.Forms.Panel();
            this.cmbRedBlendType = new System.Windows.Forms.ComboBox();
            this.cmbGreenBlendType = new System.Windows.Forms.ComboBox();
            this.cmbBlueBlendType = new System.Windows.Forms.ComboBox();
            this.lblBlendingTypes = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.picSourcePreview = new System.Windows.Forms.PictureBox();
            this.picBlendPreview = new System.Windows.Forms.PictureBox();
            this.btnLoadSourceImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlFilterControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSourcePreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlendPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(168, 13);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(400, 400);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnLoadBlendImage
            // 
            this.btnLoadBlendImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBlendImage.Location = new System.Drawing.Point(10, 375);
            this.btnLoadBlendImage.Name = "btnLoadBlendImage";
            this.btnLoadBlendImage.Size = new System.Drawing.Size(151, 38);
            this.btnLoadBlendImage.TabIndex = 15;
            this.btnLoadBlendImage.Text = "Load Image";
            this.btnLoadBlendImage.UseVisualStyleBackColor = true;
            this.btnLoadBlendImage.Click += new System.EventHandler(this.LoadImageButtonClickedEventHandler);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(574, 419);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(200, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // pnlFilterControls
            // 
            this.pnlFilterControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterControls.Controls.Add(this.cmbRedBlendType);
            this.pnlFilterControls.Controls.Add(this.cmbGreenBlendType);
            this.pnlFilterControls.Controls.Add(this.cmbBlueBlendType);
            this.pnlFilterControls.Controls.Add(this.lblBlendingTypes);
            this.pnlFilterControls.Controls.Add(this.lblRed);
            this.pnlFilterControls.Controls.Add(this.lblGreen);
            this.pnlFilterControls.Controls.Add(this.lblBlue);
            this.pnlFilterControls.Location = new System.Drawing.Point(574, 13);
            this.pnlFilterControls.Name = "pnlFilterControls";
            this.pnlFilterControls.Size = new System.Drawing.Size(200, 400);
            this.pnlFilterControls.TabIndex = 17;
            // 
            // cmbRedBlendType
            // 
            this.cmbRedBlendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRedBlendType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRedBlendType.FormattingEnabled = true;
            this.cmbRedBlendType.Location = new System.Drawing.Point(5, 306);
            this.cmbRedBlendType.Name = "cmbRedBlendType";
            this.cmbRedBlendType.Size = new System.Drawing.Size(188, 32);
            this.cmbRedBlendType.TabIndex = 25;
            this.cmbRedBlendType.SelectedIndexChanged += new System.EventHandler(this.BlendTypeSelectedIndexChangedEventHandler);
            // 
            // cmbGreenBlendType
            // 
            this.cmbGreenBlendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGreenBlendType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGreenBlendType.FormattingEnabled = true;
            this.cmbGreenBlendType.Location = new System.Drawing.Point(5, 197);
            this.cmbGreenBlendType.Name = "cmbGreenBlendType";
            this.cmbGreenBlendType.Size = new System.Drawing.Size(188, 32);
            this.cmbGreenBlendType.TabIndex = 24;
            this.cmbGreenBlendType.SelectedIndexChanged += new System.EventHandler(this.BlendTypeSelectedIndexChangedEventHandler);
            // 
            // cmbBlueBlendType
            // 
            this.cmbBlueBlendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlueBlendType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlueBlendType.FormattingEnabled = true;
            this.cmbBlueBlendType.Location = new System.Drawing.Point(5, 99);
            this.cmbBlueBlendType.Name = "cmbBlueBlendType";
            this.cmbBlueBlendType.Size = new System.Drawing.Size(188, 32);
            this.cmbBlueBlendType.TabIndex = 23;
            this.cmbBlueBlendType.SelectedIndexChanged += new System.EventHandler(this.BlendTypeSelectedIndexChangedEventHandler);
            // 
            // lblBlendingTypes
            // 
            this.lblBlendingTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlendingTypes.Location = new System.Drawing.Point(3, 0);
            this.lblBlendingTypes.Name = "lblBlendingTypes";
            this.lblBlendingTypes.Size = new System.Drawing.Size(192, 30);
            this.lblBlendingTypes.TabIndex = 22;
            this.lblBlendingTypes.Text = "Blending Types";
            this.lblBlendingTypes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(3, 273);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(190, 30);
            this.lblRed.TabIndex = 21;
            this.lblRed.Text = "Red";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(3, 164);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(190, 30);
            this.lblGreen.TabIndex = 20;
            this.lblGreen.Text = "Green";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(3, 66);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(190, 30);
            this.lblBlue.TabIndex = 19;
            this.lblBlue.Text = "Blue";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSourcePreview
            // 
            this.picSourcePreview.BackColor = System.Drawing.Color.Silver;
            this.picSourcePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSourcePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSourcePreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picSourcePreview.Location = new System.Drawing.Point(11, 14);
            this.picSourcePreview.Name = "picSourcePreview";
            this.picSourcePreview.Size = new System.Drawing.Size(150, 150);
            this.picSourcePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSourcePreview.TabIndex = 18;
            this.picSourcePreview.TabStop = false;
            // 
            // picBlendPreview
            // 
            this.picBlendPreview.BackColor = System.Drawing.Color.Silver;
            this.picBlendPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picBlendPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBlendPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picBlendPreview.Location = new System.Drawing.Point(10, 219);
            this.picBlendPreview.Name = "picBlendPreview";
            this.picBlendPreview.Size = new System.Drawing.Size(150, 150);
            this.picBlendPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBlendPreview.TabIndex = 19;
            this.picBlendPreview.TabStop = false;
            // 
            // btnLoadSourceImage
            // 
            this.btnLoadSourceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSourceImage.Location = new System.Drawing.Point(10, 173);
            this.btnLoadSourceImage.Name = "btnLoadSourceImage";
            this.btnLoadSourceImage.Size = new System.Drawing.Size(150, 38);
            this.btnLoadSourceImage.TabIndex = 20;
            this.btnLoadSourceImage.Text = "Load Image";
            this.btnLoadSourceImage.UseVisualStyleBackColor = true;
            this.btnLoadSourceImage.Click += new System.EventHandler(this.LoadImageButtonClickedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(781, 474);
            this.Controls.Add(this.btnLoadSourceImage);
            this.Controls.Add(this.picBlendPreview);
            this.Controls.Add(this.picSourcePreview);
            this.Controls.Add(this.pnlFilterControls);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnLoadBlendImage);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitwise Bitmap Blending";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlFilterControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSourcePreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlendPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnLoadBlendImage;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Panel pnlFilterControls;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblBlendingTypes;
        private System.Windows.Forms.ComboBox cmbRedBlendType;
        private System.Windows.Forms.ComboBox cmbGreenBlendType;
        private System.Windows.Forms.ComboBox cmbBlueBlendType;
        private System.Windows.Forms.PictureBox picSourcePreview;
        private System.Windows.Forms.PictureBox picBlendPreview;
        private System.Windows.Forms.Button btnLoadSourceImage;
    }
}


namespace ImageSolarise
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
            this.pnlFilterControls = new System.Windows.Forms.Panel();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.trcRed = new System.Windows.Forms.TrackBar();
            this.trcGreen = new System.Windows.Forms.TrackBar();
            this.trcBlue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlFilterControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).BeginInit();
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
            this.picPreview.Size = new System.Drawing.Size(400, 400);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 418);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(149, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(418, 418);
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
            this.pnlFilterControls.Controls.Add(this.lblRedValue);
            this.pnlFilterControls.Controls.Add(this.lblGreenValue);
            this.pnlFilterControls.Controls.Add(this.lblBlueValue);
            this.pnlFilterControls.Controls.Add(this.lblRed);
            this.pnlFilterControls.Controls.Add(this.lblGreen);
            this.pnlFilterControls.Controls.Add(this.lblBlue);
            this.pnlFilterControls.Controls.Add(this.trcRed);
            this.pnlFilterControls.Controls.Add(this.trcGreen);
            this.pnlFilterControls.Controls.Add(this.trcBlue);
            this.pnlFilterControls.Location = new System.Drawing.Point(418, 12);
            this.pnlFilterControls.Name = "pnlFilterControls";
            this.pnlFilterControls.Size = new System.Drawing.Size(200, 400);
            this.pnlFilterControls.TabIndex = 17;
            // 
            // lblRedValue
            // 
            this.lblRedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.Location = new System.Drawing.Point(137, 8);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(58, 30);
            this.lblRedValue.TabIndex = 24;
            this.lblRedValue.Text = "0";
            this.lblRedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.Location = new System.Drawing.Point(61, 8);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(70, 30);
            this.lblGreenValue.TabIndex = 23;
            this.lblGreenValue.Text = "0";
            this.lblGreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.Location = new System.Drawing.Point(3, 8);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(55, 30);
            this.lblBlueValue.TabIndex = 22;
            this.lblBlueValue.Text = "0";
            this.lblBlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.Location = new System.Drawing.Point(137, 360);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(58, 30);
            this.lblRed.TabIndex = 21;
            this.lblRed.Text = "Red";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGreen
            // 
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.Location = new System.Drawing.Point(61, 360);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(70, 30);
            this.lblGreen.TabIndex = 20;
            this.lblGreen.Text = "Green";
            this.lblGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.Location = new System.Drawing.Point(3, 360);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(55, 30);
            this.lblBlue.TabIndex = 19;
            this.lblBlue.Text = "Blue";
            this.lblBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcRed
            // 
            this.trcRed.AutoSize = false;
            this.trcRed.BackColor = System.Drawing.Color.LightGray;
            this.trcRed.Location = new System.Drawing.Point(150, 45);
            this.trcRed.Maximum = 255;
            this.trcRed.Name = "trcRed";
            this.trcRed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcRed.Size = new System.Drawing.Size(23, 309);
            this.trcRed.TabIndex = 18;
            this.trcRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcRed.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // trcGreen
            // 
            this.trcGreen.AutoSize = false;
            this.trcGreen.BackColor = System.Drawing.Color.LightGray;
            this.trcGreen.Location = new System.Drawing.Point(87, 45);
            this.trcGreen.Maximum = 255;
            this.trcGreen.Name = "trcGreen";
            this.trcGreen.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcGreen.Size = new System.Drawing.Size(23, 309);
            this.trcGreen.TabIndex = 17;
            this.trcGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcGreen.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // trcBlue
            // 
            this.trcBlue.AutoSize = false;
            this.trcBlue.BackColor = System.Drawing.Color.LightGray;
            this.trcBlue.Location = new System.Drawing.Point(25, 45);
            this.trcBlue.Maximum = 255;
            this.trcBlue.Name = "trcBlue";
            this.trcBlue.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcBlue.Size = new System.Drawing.Size(23, 309);
            this.trcBlue.TabIndex = 16;
            this.trcBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcBlue.ValueChanged += new System.EventHandler(this.ColourComponentValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(627, 472);
            this.Controls.Add(this.pnlFilterControls);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Solarise";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlFilterControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Panel pnlFilterControls;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar trcRed;
        private System.Windows.Forms.TrackBar trcGreen;
        private System.Windows.Forms.TrackBar trcBlue;
    }
}


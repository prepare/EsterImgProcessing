namespace WeightedDifferenceOfGaussians
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
            this.pnlKernelSetup = new System.Windows.Forms.Panel();
            this.numWeight2 = new System.Windows.Forms.NumericUpDown();
            this.lblWeight2 = new System.Windows.Forms.Label();
            this.numWeight1 = new System.Windows.Forms.NumericUpDown();
            this.lblKernelLenght = new System.Windows.Forms.Label();
            this.lblWeight1 = new System.Windows.Forms.Label();
            this.cmbKernelLenght = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlKernelSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight1)).BeginInit();
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
            this.btnOpenOriginal.Location = new System.Drawing.Point(622, 514);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(211, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(622, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(211, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // pnlKernelSetup
            // 
            this.pnlKernelSetup.BackColor = System.Drawing.Color.LightGray;
            this.pnlKernelSetup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKernelSetup.Controls.Add(this.numWeight2);
            this.pnlKernelSetup.Controls.Add(this.lblWeight2);
            this.pnlKernelSetup.Controls.Add(this.numWeight1);
            this.pnlKernelSetup.Controls.Add(this.lblKernelLenght);
            this.pnlKernelSetup.Controls.Add(this.lblWeight1);
            this.pnlKernelSetup.Controls.Add(this.cmbKernelLenght);
            this.pnlKernelSetup.Location = new System.Drawing.Point(622, 12);
            this.pnlKernelSetup.Name = "pnlKernelSetup";
            this.pnlKernelSetup.Size = new System.Drawing.Size(211, 248);
            this.pnlKernelSetup.TabIndex = 29;
            // 
            // numWeight2
            // 
            this.numWeight2.DecimalPlaces = 4;
            this.numWeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numWeight2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numWeight2.Location = new System.Drawing.Point(4, 201);
            this.numWeight2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numWeight2.Name = "numWeight2";
            this.numWeight2.Size = new System.Drawing.Size(197, 31);
            this.numWeight2.TabIndex = 31;
            this.numWeight2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWeight2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numWeight2.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblWeight2
            // 
            this.lblWeight2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight2.Location = new System.Drawing.Point(3, 164);
            this.lblWeight2.Name = "lblWeight2";
            this.lblWeight2.Size = new System.Drawing.Size(198, 27);
            this.lblWeight2.TabIndex = 30;
            this.lblWeight2.Text = "Weight 2";
            this.lblWeight2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numWeight1
            // 
            this.numWeight1.DecimalPlaces = 4;
            this.numWeight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numWeight1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numWeight1.Location = new System.Drawing.Point(4, 123);
            this.numWeight1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numWeight1.Name = "numWeight1";
            this.numWeight1.Size = new System.Drawing.Size(197, 31);
            this.numWeight1.TabIndex = 29;
            this.numWeight1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numWeight1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numWeight1.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblKernelLenght
            // 
            this.lblKernelLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKernelLenght.Location = new System.Drawing.Point(3, 5);
            this.lblKernelLenght.Name = "lblKernelLenght";
            this.lblKernelLenght.Size = new System.Drawing.Size(198, 30);
            this.lblKernelLenght.TabIndex = 23;
            this.lblKernelLenght.Text = "Kernel Size";
            this.lblKernelLenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight1
            // 
            this.lblWeight1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight1.Location = new System.Drawing.Point(3, 86);
            this.lblWeight1.Name = "lblWeight1";
            this.lblWeight1.Size = new System.Drawing.Size(198, 27);
            this.lblWeight1.TabIndex = 24;
            this.lblWeight1.Text = "Weight 1";
            this.lblWeight1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbKernelLenght
            // 
            this.cmbKernelLenght.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKernelLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKernelLenght.FormattingEnabled = true;
            this.cmbKernelLenght.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "17",
            "19"});
            this.cmbKernelLenght.Location = new System.Drawing.Point(6, 45);
            this.cmbKernelLenght.Name = "cmbKernelLenght";
            this.cmbKernelLenght.Size = new System.Drawing.Size(195, 32);
            this.cmbKernelLenght.TabIndex = 22;
            this.cmbKernelLenght.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(839, 620);
            this.Controls.Add(this.pnlKernelSetup);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weighted Difference Of Gaussians";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlKernelSetup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numWeight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Panel pnlKernelSetup;
        private System.Windows.Forms.NumericUpDown numWeight2;
        private System.Windows.Forms.Label lblWeight2;
        private System.Windows.Forms.NumericUpDown numWeight1;
        private System.Windows.Forms.Label lblKernelLenght;
        private System.Windows.Forms.Label lblWeight1;
        private System.Windows.Forms.ComboBox cmbKernelLenght;
    }
}


namespace FuzzyBlurFilter
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
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.lblEdge1 = new System.Windows.Forms.Label();
            this.numEdge1 = new System.Windows.Forms.NumericUpDown();
            this.numEdge2 = new System.Windows.Forms.NumericUpDown();
            this.lblEdge2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdge2)).BeginInit();
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
            this.picPreview.Size = new System.Drawing.Size(700, 700);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(722, 614);
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
            this.btnSaveNewImage.Location = new System.Drawing.Point(722, 666);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(228, 46);
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
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "17",
            "19"});
            this.cmbFilterSize.Location = new System.Drawing.Point(722, 48);
            this.cmbFilterSize.Name = "cmbFilterSize";
            this.cmbFilterSize.Size = new System.Drawing.Size(228, 32);
            this.cmbFilterSize.TabIndex = 20;
            this.cmbFilterSize.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSize.Location = new System.Drawing.Point(718, 12);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(232, 30);
            this.lblFilterSize.TabIndex = 26;
            this.lblFilterSize.Text = "Filter Size";
            this.lblFilterSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdge1
            // 
            this.lblEdge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdge1.Location = new System.Drawing.Point(718, 98);
            this.lblEdge1.Name = "lblEdge1";
            this.lblEdge1.Size = new System.Drawing.Size(103, 30);
            this.lblEdge1.TabIndex = 27;
            this.lblEdge1.Text = "Edge 1";
            this.lblEdge1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEdge1
            // 
            this.numEdge1.DecimalPlaces = 3;
            this.numEdge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEdge1.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.numEdge1.Location = new System.Drawing.Point(827, 98);
            this.numEdge1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numEdge1.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.numEdge1.Name = "numEdge1";
            this.numEdge1.Size = new System.Drawing.Size(120, 31);
            this.numEdge1.TabIndex = 28;
            this.numEdge1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEdge1.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numEdge1.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // numEdge2
            // 
            this.numEdge2.DecimalPlaces = 3;
            this.numEdge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEdge2.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.numEdge2.Location = new System.Drawing.Point(827, 135);
            this.numEdge2.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numEdge2.Minimum = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.numEdge2.Name = "numEdge2";
            this.numEdge2.Size = new System.Drawing.Size(120, 31);
            this.numEdge2.TabIndex = 30;
            this.numEdge2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEdge2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numEdge2.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblEdge2
            // 
            this.lblEdge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdge2.Location = new System.Drawing.Point(718, 135);
            this.lblEdge2.Name = "lblEdge2";
            this.lblEdge2.Size = new System.Drawing.Size(103, 30);
            this.lblEdge2.TabIndex = 29;
            this.lblEdge2.Text = "Edge 2";
            this.lblEdge2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 720);
            this.Controls.Add(this.numEdge2);
            this.Controls.Add(this.lblEdge2);
            this.Controls.Add(this.numEdge1);
            this.Controls.Add(this.lblEdge1);
            this.Controls.Add(this.lblFilterSize);
            this.Controls.Add(this.cmbFilterSize);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuzzy Blur Filter";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEdge2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbFilterSize;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.Label lblEdge1;
        private System.Windows.Forms.NumericUpDown numEdge1;
        private System.Windows.Forms.NumericUpDown numEdge2;
        private System.Windows.Forms.Label lblEdge2;
    }
}


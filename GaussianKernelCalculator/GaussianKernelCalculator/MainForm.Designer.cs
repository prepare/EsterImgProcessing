namespace GaussianKernelCalculator
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
            this.txtKernal = new System.Windows.Forms.TextBox();
            this.cmbKernelLenght = new System.Windows.Forms.ComboBox();
            this.lblKernelLenght = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlKernelControls = new System.Windows.Forms.Panel();
            this.btnCopyCSharp = new System.Windows.Forms.Button();
            this.btnCopyText = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numKernelWeight = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.pnlKernelControls.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKernelWeight)).BeginInit();
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
            this.btnOpenOriginal.Location = new System.Drawing.Point(630, 566);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(182, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(1000, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(182, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // txtKernal
            // 
            this.txtKernal.AcceptsReturn = true;
            this.txtKernal.AcceptsTab = true;
            this.txtKernal.BackColor = System.Drawing.Color.Black;
            this.txtKernal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKernal.Font = new System.Drawing.Font("Consolas", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKernal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtKernal.HideSelection = false;
            this.txtKernal.Location = new System.Drawing.Point(630, 12);
            this.txtKernal.Multiline = true;
            this.txtKernal.Name = "txtKernal";
            this.txtKernal.ReadOnly = true;
            this.txtKernal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKernal.Size = new System.Drawing.Size(552, 440);
            this.txtKernal.TabIndex = 21;
            this.txtKernal.WordWrap = false;
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
            this.cmbKernelLenght.Size = new System.Drawing.Size(157, 32);
            this.cmbKernelLenght.TabIndex = 22;
            this.cmbKernelLenght.SelectedIndexChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblKernelLenght
            // 
            this.lblKernelLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKernelLenght.Location = new System.Drawing.Point(3, 5);
            this.lblKernelLenght.Name = "lblKernelLenght";
            this.lblKernelLenght.Size = new System.Drawing.Size(160, 30);
            this.lblKernelLenght.TabIndex = 23;
            this.lblKernelLenght.Text = "Kernel Lenght";
            this.lblKernelLenght.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 27);
            this.label1.TabIndex = 24;
            this.label1.Text = "Weight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlKernelControls
            // 
            this.pnlKernelControls.BackColor = System.Drawing.Color.Silver;
            this.pnlKernelControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKernelControls.Controls.Add(this.btnCopyCSharp);
            this.pnlKernelControls.Controls.Add(this.btnCopyText);
            this.pnlKernelControls.Controls.Add(this.panel1);
            this.pnlKernelControls.Location = new System.Drawing.Point(630, 458);
            this.pnlKernelControls.Name = "pnlKernelControls";
            this.pnlKernelControls.Size = new System.Drawing.Size(552, 101);
            this.pnlKernelControls.TabIndex = 28;
            // 
            // btnCopyCSharp
            // 
            this.btnCopyCSharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyCSharp.Location = new System.Drawing.Point(364, 53);
            this.btnCopyCSharp.Name = "btnCopyCSharp";
            this.btnCopyCSharp.Size = new System.Drawing.Size(178, 40);
            this.btnCopyCSharp.TabIndex = 30;
            this.btnCopyCSharp.Text = "Copy C# Array";
            this.btnCopyCSharp.UseVisualStyleBackColor = true;
            this.btnCopyCSharp.Click += new System.EventHandler(this.btnCopyCSharp_Click);
            // 
            // btnCopyText
            // 
            this.btnCopyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyText.Location = new System.Drawing.Point(363, 5);
            this.btnCopyText.Name = "btnCopyText";
            this.btnCopyText.Size = new System.Drawing.Size(178, 40);
            this.btnCopyText.TabIndex = 29;
            this.btnCopyText.Text = "Copy Text";
            this.btnCopyText.UseVisualStyleBackColor = true;
            this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numKernelWeight);
            this.panel1.Controls.Add(this.lblKernelLenght);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbKernelLenght);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 88);
            this.panel1.TabIndex = 28;
            // 
            // numKernelWeight
            // 
            this.numKernelWeight.DecimalPlaces = 4;
            this.numKernelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numKernelWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numKernelWeight.Location = new System.Drawing.Point(181, 44);
            this.numKernelWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numKernelWeight.Name = "numKernelWeight";
            this.numKernelWeight.Size = new System.Drawing.Size(157, 31);
            this.numKernelWeight.TabIndex = 29;
            this.numKernelWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numKernelWeight.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numKernelWeight.ValueChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1194, 621);
            this.Controls.Add(this.pnlKernelControls);
            this.Controls.Add(this.txtKernal);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gaussian Kernel Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.pnlKernelControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKernelWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.TextBox txtKernal;
        private System.Windows.Forms.ComboBox cmbKernelLenght;
        private System.Windows.Forms.Label lblKernelLenght;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlKernelControls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCopyCSharp;
        private System.Windows.Forms.Button btnCopyText;
        private System.Windows.Forms.NumericUpDown numKernelWeight;
    }
}


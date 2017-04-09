namespace ImageASCIIArt
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
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.pnlEdgeDetectionType = new System.Windows.Forms.Panel();
            this.numPixelsToChar = new System.Windows.Forms.NumericUpDown();
            this.lblEdgeDetectionType = new System.Windows.Forms.Label();
            this.txtAscii = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numColors = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numFontSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.pnlEdgeDetectionType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPixelsToChar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numColors)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(771, 664);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(241, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(771, 716);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(241, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // pnlEdgeDetectionType
            // 
            this.pnlEdgeDetectionType.BackColor = System.Drawing.Color.Silver;
            this.pnlEdgeDetectionType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdgeDetectionType.Controls.Add(this.numPixelsToChar);
            this.pnlEdgeDetectionType.Controls.Add(this.lblEdgeDetectionType);
            this.pnlEdgeDetectionType.Location = new System.Drawing.Point(771, 12);
            this.pnlEdgeDetectionType.Name = "pnlEdgeDetectionType";
            this.pnlEdgeDetectionType.Size = new System.Drawing.Size(241, 71);
            this.pnlEdgeDetectionType.TabIndex = 21;
            // 
            // numPixelsToChar
            // 
            this.numPixelsToChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numPixelsToChar.Location = new System.Drawing.Point(140, 21);
            this.numPixelsToChar.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numPixelsToChar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPixelsToChar.Name = "numPixelsToChar";
            this.numPixelsToChar.Size = new System.Drawing.Size(95, 31);
            this.numPixelsToChar.TabIndex = 1;
            this.numPixelsToChar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPixelsToChar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPixelsToChar.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblEdgeDetectionType
            // 
            this.lblEdgeDetectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeDetectionType.Location = new System.Drawing.Point(3, 1);
            this.lblEdgeDetectionType.Name = "lblEdgeDetectionType";
            this.lblEdgeDetectionType.Size = new System.Drawing.Size(119, 68);
            this.lblEdgeDetectionType.TabIndex = 0;
            this.lblEdgeDetectionType.Text = "Pixels Per Character";
            this.lblEdgeDetectionType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAscii
            // 
            this.txtAscii.BackColor = System.Drawing.Color.White;
            this.txtAscii.DetectUrls = false;
            this.txtAscii.Font = new System.Drawing.Font("Courier New", 6F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAscii.ForeColor = System.Drawing.Color.Black;
            this.txtAscii.Location = new System.Drawing.Point(12, 12);
            this.txtAscii.Name = "txtAscii";
            this.txtAscii.Size = new System.Drawing.Size(750, 750);
            this.txtAscii.TabIndex = 22;
            this.txtAscii.Text = "";
            this.txtAscii.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numZoom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(771, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 43);
            this.panel1.TabIndex = 23;
            // 
            // numZoom
            // 
            this.numZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numZoom.Location = new System.Drawing.Point(140, 6);
            this.numZoom.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(95, 31);
            this.numZoom.TabIndex = 1;
            this.numZoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numZoom.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numZoom.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoom %";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.numColors);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(771, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 71);
            this.panel2.TabIndex = 24;
            // 
            // numColors
            // 
            this.numColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numColors.Location = new System.Drawing.Point(140, 21);
            this.numColors.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numColors.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numColors.Name = "numColors";
            this.numColors.Size = new System.Drawing.Size(95, 31);
            this.numColors.TabIndex = 1;
            this.numColors.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numColors.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numColors.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = "Character Count";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.numFontSize);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(771, 166);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(241, 43);
            this.panel3.TabIndex = 25;
            // 
            // numFontSize
            // 
            this.numFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numFontSize.Location = new System.Drawing.Point(140, 6);
            this.numFontSize.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.numFontSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numFontSize.Name = "numFontSize";
            this.numFontSize.Size = new System.Drawing.Size(95, 31);
            this.numFontSize.TabIndex = 1;
            this.numFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFontSize.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFontSize.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Font Size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToClipboard.Location = new System.Drawing.Point(771, 612);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(241, 46);
            this.btnCopyToClipboard.TabIndex = 26;
            this.btnCopyToClipboard.Text = "Copy to Clipboard";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1018, 773);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAscii);
            this.Controls.Add(this.pnlEdgeDetectionType);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image ASCII Art ";
            this.pnlEdgeDetectionType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPixelsToChar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numColors)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Panel pnlEdgeDetectionType;
        private System.Windows.Forms.Label lblEdgeDetectionType;
        private System.Windows.Forms.RichTextBox txtAscii;
        private System.Windows.Forms.NumericUpDown numPixelsToChar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numColors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown numFontSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCopyToClipboard;
    }
}


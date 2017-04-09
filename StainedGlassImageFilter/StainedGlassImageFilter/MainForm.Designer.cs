namespace StainedGlassImageFilter
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
            this.numBlockSize = new System.Windows.Forms.NumericUpDown();
            this.numBlockFactor = new System.Windows.Forms.NumericUpDown();
            this.pnlBlockProperties = new System.Windows.Forms.Panel();
            this.lblDistanceFormula = new System.Windows.Forms.Label();
            this.cmbDistanceType = new System.Windows.Forms.ComboBox();
            this.lblBlockFactor = new System.Windows.Forms.Label();
            this.lblBlockSize = new System.Windows.Forms.Label();
            this.lblBlockProperties = new System.Windows.Forms.Label();
            this.chkHighlightEdges = new System.Windows.Forms.CheckBox();
            this.pnlEdgeThreshold = new System.Windows.Forms.Panel();
            this.btnColour = new System.Windows.Forms.Button();
            this.lblEdgeColour = new System.Windows.Forms.Label();
            this.numEdgeThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblEdgeProperties = new System.Windows.Forms.Label();
            this.lblEdgeThresholdInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockFactor)).BeginInit();
            this.pnlBlockProperties.SuspendLayout();
            this.pnlEdgeThreshold.SuspendLayout();
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
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(619, 514);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(252, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(619, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(251, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // numBlockSize
            // 
            this.numBlockSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBlockSize.Location = new System.Drawing.Point(143, 39);
            this.numBlockSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBlockSize.Name = "numBlockSize";
            this.numBlockSize.Size = new System.Drawing.Size(103, 31);
            this.numBlockSize.TabIndex = 21;
            this.numBlockSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBlockSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numBlockSize.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // numBlockFactor
            // 
            this.numBlockFactor.DecimalPlaces = 2;
            this.numBlockFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBlockFactor.Location = new System.Drawing.Point(143, 79);
            this.numBlockFactor.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numBlockFactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBlockFactor.Name = "numBlockFactor";
            this.numBlockFactor.Size = new System.Drawing.Size(103, 31);
            this.numBlockFactor.TabIndex = 22;
            this.numBlockFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBlockFactor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numBlockFactor.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // pnlBlockProperties
            // 
            this.pnlBlockProperties.BackColor = System.Drawing.Color.Silver;
            this.pnlBlockProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlockProperties.Controls.Add(this.lblDistanceFormula);
            this.pnlBlockProperties.Controls.Add(this.cmbDistanceType);
            this.pnlBlockProperties.Controls.Add(this.lblBlockFactor);
            this.pnlBlockProperties.Controls.Add(this.lblBlockSize);
            this.pnlBlockProperties.Controls.Add(this.numBlockSize);
            this.pnlBlockProperties.Controls.Add(this.numBlockFactor);
            this.pnlBlockProperties.Controls.Add(this.lblBlockProperties);
            this.pnlBlockProperties.Location = new System.Drawing.Point(619, 12);
            this.pnlBlockProperties.Name = "pnlBlockProperties";
            this.pnlBlockProperties.Size = new System.Drawing.Size(251, 196);
            this.pnlBlockProperties.TabIndex = 24;
            // 
            // lblDistanceFormula
            // 
            this.lblDistanceFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceFormula.Location = new System.Drawing.Point(3, 117);
            this.lblDistanceFormula.Name = "lblDistanceFormula";
            this.lblDistanceFormula.Size = new System.Drawing.Size(243, 31);
            this.lblDistanceFormula.TabIndex = 24;
            this.lblDistanceFormula.Text = "Distance Formula:";
            this.lblDistanceFormula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbDistanceType
            // 
            this.cmbDistanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDistanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDistanceType.FormattingEnabled = true;
            this.cmbDistanceType.Location = new System.Drawing.Point(8, 151);
            this.cmbDistanceType.Name = "cmbDistanceType";
            this.cmbDistanceType.Size = new System.Drawing.Size(238, 32);
            this.cmbDistanceType.TabIndex = 23;
            this.cmbDistanceType.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblBlockFactor
            // 
            this.lblBlockFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockFactor.Location = new System.Drawing.Point(3, 79);
            this.lblBlockFactor.Name = "lblBlockFactor";
            this.lblBlockFactor.Size = new System.Drawing.Size(134, 31);
            this.lblBlockFactor.TabIndex = 2;
            this.lblBlockFactor.Text = "Factor:";
            this.lblBlockFactor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBlockSize
            // 
            this.lblBlockSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockSize.Location = new System.Drawing.Point(3, 39);
            this.lblBlockSize.Name = "lblBlockSize";
            this.lblBlockSize.Size = new System.Drawing.Size(134, 31);
            this.lblBlockSize.TabIndex = 1;
            this.lblBlockSize.Text = "Size:";
            this.lblBlockSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBlockProperties
            // 
            this.lblBlockProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockProperties.Location = new System.Drawing.Point(3, 6);
            this.lblBlockProperties.Name = "lblBlockProperties";
            this.lblBlockProperties.Size = new System.Drawing.Size(243, 29);
            this.lblBlockProperties.TabIndex = 0;
            this.lblBlockProperties.Text = "Block Properties";
            this.lblBlockProperties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkHighlightEdges
            // 
            this.chkHighlightEdges.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHighlightEdges.Location = new System.Drawing.Point(8, 36);
            this.chkHighlightEdges.Name = "chkHighlightEdges";
            this.chkHighlightEdges.Size = new System.Drawing.Size(238, 29);
            this.chkHighlightEdges.TabIndex = 39;
            this.chkHighlightEdges.Text = "Highlight Edges";
            this.chkHighlightEdges.UseVisualStyleBackColor = true;
            this.chkHighlightEdges.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // pnlEdgeThreshold
            // 
            this.pnlEdgeThreshold.BackColor = System.Drawing.Color.Silver;
            this.pnlEdgeThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEdgeThreshold.Controls.Add(this.btnColour);
            this.pnlEdgeThreshold.Controls.Add(this.lblEdgeColour);
            this.pnlEdgeThreshold.Controls.Add(this.numEdgeThreshold);
            this.pnlEdgeThreshold.Controls.Add(this.chkHighlightEdges);
            this.pnlEdgeThreshold.Controls.Add(this.lblEdgeProperties);
            this.pnlEdgeThreshold.Controls.Add(this.lblEdgeThresholdInfo);
            this.pnlEdgeThreshold.Location = new System.Drawing.Point(619, 214);
            this.pnlEdgeThreshold.Name = "pnlEdgeThreshold";
            this.pnlEdgeThreshold.Size = new System.Drawing.Size(251, 166);
            this.pnlEdgeThreshold.TabIndex = 38;
            // 
            // btnColour
            // 
            this.btnColour.BackColor = System.Drawing.Color.Black;
            this.btnColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColour.Location = new System.Drawing.Point(144, 115);
            this.btnColour.Name = "btnColour";
            this.btnColour.Size = new System.Drawing.Size(102, 34);
            this.btnColour.TabIndex = 42;
            this.btnColour.UseVisualStyleBackColor = false;
            this.btnColour.Click += new System.EventHandler(this.btnColour_Click);
            // 
            // lblEdgeColour
            // 
            this.lblEdgeColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeColour.Location = new System.Drawing.Point(3, 115);
            this.lblEdgeColour.Name = "lblEdgeColour";
            this.lblEdgeColour.Size = new System.Drawing.Size(133, 34);
            this.lblEdgeColour.TabIndex = 41;
            this.lblEdgeColour.Text = "Colour:";
            this.lblEdgeColour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numEdgeThreshold
            // 
            this.numEdgeThreshold.Enabled = false;
            this.numEdgeThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numEdgeThreshold.Location = new System.Drawing.Point(143, 74);
            this.numEdgeThreshold.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numEdgeThreshold.Name = "numEdgeThreshold";
            this.numEdgeThreshold.Size = new System.Drawing.Size(103, 31);
            this.numEdgeThreshold.TabIndex = 40;
            this.numEdgeThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numEdgeThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numEdgeThreshold.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblEdgeProperties
            // 
            this.lblEdgeProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeProperties.Location = new System.Drawing.Point(3, 0);
            this.lblEdgeProperties.Name = "lblEdgeProperties";
            this.lblEdgeProperties.Size = new System.Drawing.Size(243, 30);
            this.lblEdgeProperties.TabIndex = 29;
            this.lblEdgeProperties.Text = "Edge Properies";
            this.lblEdgeProperties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdgeThresholdInfo
            // 
            this.lblEdgeThresholdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdgeThresholdInfo.Location = new System.Drawing.Point(4, 74);
            this.lblEdgeThresholdInfo.Name = "lblEdgeThresholdInfo";
            this.lblEdgeThresholdInfo.Size = new System.Drawing.Size(133, 31);
            this.lblEdgeThresholdInfo.TabIndex = 28;
            this.lblEdgeThresholdInfo.Text = "Threshold:";
            this.lblEdgeThresholdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(882, 625);
            this.Controls.Add(this.pnlEdgeThreshold);
            this.Controls.Add(this.pnlBlockProperties);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stained Glass Image Filter";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBlockFactor)).EndInit();
            this.pnlBlockProperties.ResumeLayout(false);
            this.pnlEdgeThreshold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numEdgeThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.NumericUpDown numBlockSize;
        private System.Windows.Forms.NumericUpDown numBlockFactor;
        private System.Windows.Forms.Panel pnlBlockProperties;
        private System.Windows.Forms.Label lblBlockFactor;
        private System.Windows.Forms.Label lblBlockSize;
        private System.Windows.Forms.Label lblBlockProperties;
        private System.Windows.Forms.CheckBox chkHighlightEdges;
        private System.Windows.Forms.Panel pnlEdgeThreshold;
        private System.Windows.Forms.Label lblEdgeThresholdInfo;
        private System.Windows.Forms.NumericUpDown numEdgeThreshold;
        private System.Windows.Forms.Label lblEdgeProperties;
        private System.Windows.Forms.Button btnColour;
        private System.Windows.Forms.Label lblEdgeColour;
        private System.Windows.Forms.Label lblDistanceFormula;
        private System.Windows.Forms.ComboBox cmbDistanceType;
    }
}


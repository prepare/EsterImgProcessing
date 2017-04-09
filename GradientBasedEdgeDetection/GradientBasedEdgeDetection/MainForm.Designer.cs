namespace GradientBasedEdgeDetection
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
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.trcThreshold = new System.Windows.Forms.TrackBar();
            this.lblThresholdInfo = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.pnlThreshold = new System.Windows.Forms.Panel();
            this.pnlRed = new System.Windows.Forms.Panel();
            this.lblRedInfo = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.trcRedValue = new System.Windows.Forms.TrackBar();
            this.pnlGreen = new System.Windows.Forms.Panel();
            this.lblGreenInfo = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.trcGreenValue = new System.Windows.Forms.TrackBar();
            this.pnlBlue = new System.Windows.Forms.Panel();
            this.lblBlueInfo = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.trcBlueValue = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdFirstDerivative = new System.Windows.Forms.RadioButton();
            this.rdSecondDerivative = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).BeginInit();
            this.pnlThreshold.SuspendLayout();
            this.pnlRed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcRedValue)).BeginInit();
            this.pnlGreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcGreenValue)).BeginInit();
            this.pnlBlue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcBlueValue)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.btnOpenOriginal.Location = new System.Drawing.Point(618, 514);
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
            this.btnSaveNewImage.Location = new System.Drawing.Point(618, 566);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(228, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(618, 45);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(228, 32);
            this.cmbFilterType.TabIndex = 20;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblFilterType
            // 
            this.lblFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterType.Location = new System.Drawing.Point(614, 12);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(232, 30);
            this.lblFilterType.TabIndex = 26;
            this.lblFilterType.Text = "Filter Type";
            this.lblFilterType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.SystemColors.Control;
            this.trcThreshold.Location = new System.Drawing.Point(7, 33);
            this.trcThreshold.Maximum = 200;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Size = new System.Drawing.Size(213, 30);
            this.trcThreshold.TabIndex = 27;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // lblThresholdInfo
            // 
            this.lblThresholdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThresholdInfo.Location = new System.Drawing.Point(3, 0);
            this.lblThresholdInfo.Name = "lblThresholdInfo";
            this.lblThresholdInfo.Size = new System.Drawing.Size(112, 30);
            this.lblThresholdInfo.TabIndex = 28;
            this.lblThresholdInfo.Text = "Threshold:";
            this.lblThresholdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreshold
            // 
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(142, 0);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(74, 30);
            this.lblThreshold.TabIndex = 29;
            this.lblThreshold.Text = "0";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlThreshold
            // 
            this.pnlThreshold.BackColor = System.Drawing.Color.Silver;
            this.pnlThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThreshold.Controls.Add(this.lblThresholdInfo);
            this.pnlThreshold.Controls.Add(this.lblThreshold);
            this.pnlThreshold.Controls.Add(this.trcThreshold);
            this.pnlThreshold.Location = new System.Drawing.Point(618, 165);
            this.pnlThreshold.Name = "pnlThreshold";
            this.pnlThreshold.Size = new System.Drawing.Size(228, 76);
            this.pnlThreshold.TabIndex = 30;
            // 
            // pnlRed
            // 
            this.pnlRed.BackColor = System.Drawing.Color.Silver;
            this.pnlRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRed.Controls.Add(this.lblRedInfo);
            this.pnlRed.Controls.Add(this.lblRedValue);
            this.pnlRed.Controls.Add(this.trcRedValue);
            this.pnlRed.Location = new System.Drawing.Point(618, 247);
            this.pnlRed.Name = "pnlRed";
            this.pnlRed.Size = new System.Drawing.Size(228, 76);
            this.pnlRed.TabIndex = 31;
            // 
            // lblRedInfo
            // 
            this.lblRedInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedInfo.Location = new System.Drawing.Point(3, 0);
            this.lblRedInfo.Name = "lblRedInfo";
            this.lblRedInfo.Size = new System.Drawing.Size(112, 30);
            this.lblRedInfo.TabIndex = 28;
            this.lblRedInfo.Text = "Red:";
            this.lblRedInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRedValue
            // 
            this.lblRedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRedValue.Location = new System.Drawing.Point(142, 0);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(74, 30);
            this.lblRedValue.TabIndex = 29;
            this.lblRedValue.Text = "100%";
            this.lblRedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trcRedValue
            // 
            this.trcRedValue.AutoSize = false;
            this.trcRedValue.BackColor = System.Drawing.SystemColors.Control;
            this.trcRedValue.Location = new System.Drawing.Point(7, 33);
            this.trcRedValue.Maximum = 300;
            this.trcRedValue.Name = "trcRedValue";
            this.trcRedValue.Size = new System.Drawing.Size(213, 30);
            this.trcRedValue.TabIndex = 27;
            this.trcRedValue.Value = 100;
            this.trcRedValue.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // pnlGreen
            // 
            this.pnlGreen.BackColor = System.Drawing.Color.Silver;
            this.pnlGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGreen.Controls.Add(this.lblGreenInfo);
            this.pnlGreen.Controls.Add(this.lblGreenValue);
            this.pnlGreen.Controls.Add(this.trcGreenValue);
            this.pnlGreen.Location = new System.Drawing.Point(618, 329);
            this.pnlGreen.Name = "pnlGreen";
            this.pnlGreen.Size = new System.Drawing.Size(228, 76);
            this.pnlGreen.TabIndex = 32;
            // 
            // lblGreenInfo
            // 
            this.lblGreenInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenInfo.Location = new System.Drawing.Point(3, 0);
            this.lblGreenInfo.Name = "lblGreenInfo";
            this.lblGreenInfo.Size = new System.Drawing.Size(112, 30);
            this.lblGreenInfo.TabIndex = 28;
            this.lblGreenInfo.Text = "Green:";
            this.lblGreenInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGreenValue
            // 
            this.lblGreenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreenValue.Location = new System.Drawing.Point(142, 0);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(74, 30);
            this.lblGreenValue.TabIndex = 29;
            this.lblGreenValue.Text = "100%";
            this.lblGreenValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trcGreenValue
            // 
            this.trcGreenValue.AutoSize = false;
            this.trcGreenValue.BackColor = System.Drawing.SystemColors.Control;
            this.trcGreenValue.Location = new System.Drawing.Point(7, 33);
            this.trcGreenValue.Maximum = 300;
            this.trcGreenValue.Name = "trcGreenValue";
            this.trcGreenValue.Size = new System.Drawing.Size(213, 30);
            this.trcGreenValue.TabIndex = 27;
            this.trcGreenValue.Value = 100;
            this.trcGreenValue.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // pnlBlue
            // 
            this.pnlBlue.BackColor = System.Drawing.Color.Silver;
            this.pnlBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBlue.Controls.Add(this.lblBlueInfo);
            this.pnlBlue.Controls.Add(this.lblBlueValue);
            this.pnlBlue.Controls.Add(this.trcBlueValue);
            this.pnlBlue.Location = new System.Drawing.Point(618, 411);
            this.pnlBlue.Name = "pnlBlue";
            this.pnlBlue.Size = new System.Drawing.Size(228, 76);
            this.pnlBlue.TabIndex = 33;
            // 
            // lblBlueInfo
            // 
            this.lblBlueInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueInfo.Location = new System.Drawing.Point(3, 0);
            this.lblBlueInfo.Name = "lblBlueInfo";
            this.lblBlueInfo.Size = new System.Drawing.Size(112, 30);
            this.lblBlueInfo.TabIndex = 28;
            this.lblBlueInfo.Text = "Blue:";
            this.lblBlueInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlueValue.Location = new System.Drawing.Point(142, 0);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(74, 30);
            this.lblBlueValue.TabIndex = 29;
            this.lblBlueValue.Text = "100%";
            this.lblBlueValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trcBlueValue
            // 
            this.trcBlueValue.AutoSize = false;
            this.trcBlueValue.BackColor = System.Drawing.SystemColors.Control;
            this.trcBlueValue.Location = new System.Drawing.Point(7, 33);
            this.trcBlueValue.Maximum = 300;
            this.trcBlueValue.Name = "trcBlueValue";
            this.trcBlueValue.Size = new System.Drawing.Size(213, 30);
            this.trcBlueValue.TabIndex = 27;
            this.trcBlueValue.Value = 100;
            this.trcBlueValue.ValueChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdSecondDerivative);
            this.panel1.Controls.Add(this.rdFirstDerivative);
            this.panel1.Location = new System.Drawing.Point(618, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 76);
            this.panel1.TabIndex = 34;
            // 
            // rdFirstDerivative
            // 
            this.rdFirstDerivative.AutoSize = true;
            this.rdFirstDerivative.Checked = true;
            this.rdFirstDerivative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdFirstDerivative.Location = new System.Drawing.Point(7, 3);
            this.rdFirstDerivative.Name = "rdFirstDerivative";
            this.rdFirstDerivative.Size = new System.Drawing.Size(190, 29);
            this.rdFirstDerivative.TabIndex = 0;
            this.rdFirstDerivative.TabStop = true;
            this.rdFirstDerivative.Text = "First Derivative";
            this.rdFirstDerivative.UseVisualStyleBackColor = true;
            this.rdFirstDerivative.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // rdSecondDerivative
            // 
            this.rdSecondDerivative.AutoSize = true;
            this.rdSecondDerivative.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSecondDerivative.Location = new System.Drawing.Point(7, 38);
            this.rdSecondDerivative.Name = "rdSecondDerivative";
            this.rdSecondDerivative.Size = new System.Drawing.Size(222, 29);
            this.rdSecondDerivative.TabIndex = 1;
            this.rdSecondDerivative.Text = "Second Derivative";
            this.rdSecondDerivative.UseVisualStyleBackColor = true;
            this.rdSecondDerivative.CheckedChanged += new System.EventHandler(this.FilterValueChangedEventHandler);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(853, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBlue);
            this.Controls.Add(this.pnlGreen);
            this.Controls.Add(this.pnlRed);
            this.Controls.Add(this.pnlThreshold);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gradient Based Edge Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            this.pnlThreshold.ResumeLayout(false);
            this.pnlRed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcRedValue)).EndInit();
            this.pnlGreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcGreenValue)).EndInit();
            this.pnlBlue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcBlueValue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.TrackBar trcThreshold;
        private System.Windows.Forms.Label lblThresholdInfo;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Panel pnlThreshold;
        private System.Windows.Forms.Panel pnlRed;
        private System.Windows.Forms.Label lblRedInfo;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.TrackBar trcRedValue;
        private System.Windows.Forms.Panel pnlGreen;
        private System.Windows.Forms.Label lblGreenInfo;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.TrackBar trcGreenValue;
        private System.Windows.Forms.Panel pnlBlue;
        private System.Windows.Forms.Label lblBlueInfo;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.TrackBar trcBlueValue;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdSecondDerivative;
        private System.Windows.Forms.RadioButton rdFirstDerivative;
    }
}


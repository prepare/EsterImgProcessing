namespace WinFormsKinectCameraViewer
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
            this.cmbSensors = new System.Windows.Forms.ComboBox();
            this.grbSensor = new System.Windows.Forms.GroupBox();
            this.cmbDisplayMode = new System.Windows.Forms.ComboBox();
            this.btnActivateSensor = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblConnectedSensors = new System.Windows.Forms.Label();
            this.picVideoDisplay = new System.Windows.Forms.PictureBox();
            this.grbSensor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSensors
            // 
            this.cmbSensors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensors.FormattingEnabled = true;
            this.cmbSensors.Location = new System.Drawing.Point(6, 39);
            this.cmbSensors.Name = "cmbSensors";
            this.cmbSensors.Size = new System.Drawing.Size(272, 21);
            this.cmbSensors.TabIndex = 0;
            // 
            // grbSensor
            // 
            this.grbSensor.Controls.Add(this.cmbDisplayMode);
            this.grbSensor.Controls.Add(this.btnActivateSensor);
            this.grbSensor.Controls.Add(this.btnRefresh);
            this.grbSensor.Controls.Add(this.lblConnectedSensors);
            this.grbSensor.Controls.Add(this.cmbSensors);
            this.grbSensor.Location = new System.Drawing.Point(12, 498);
            this.grbSensor.Name = "grbSensor";
            this.grbSensor.Size = new System.Drawing.Size(640, 76);
            this.grbSensor.TabIndex = 1;
            this.grbSensor.TabStop = false;
            this.grbSensor.Text = "Sensor Settings";
            // 
            // cmbDisplayMode
            // 
            this.cmbDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisplayMode.FormattingEnabled = true;
            this.cmbDisplayMode.Location = new System.Drawing.Point(356, 39);
            this.cmbDisplayMode.Name = "cmbDisplayMode";
            this.cmbDisplayMode.Size = new System.Drawing.Size(195, 21);
            this.cmbDisplayMode.TabIndex = 4;
            // 
            // btnActivateSensor
            // 
            this.btnActivateSensor.Location = new System.Drawing.Point(557, 37);
            this.btnActivateSensor.Name = "btnActivateSensor";
            this.btnActivateSensor.Size = new System.Drawing.Size(77, 23);
            this.btnActivateSensor.TabIndex = 3;
            this.btnActivateSensor.Text = "Activate";
            this.btnActivateSensor.UseVisualStyleBackColor = true;
            this.btnActivateSensor.Click += new System.EventHandler(this.btnActivateSensor_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(284, 37);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(66, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblConnectedSensors
            // 
            this.lblConnectedSensors.AutoSize = true;
            this.lblConnectedSensors.Location = new System.Drawing.Point(6, 23);
            this.lblConnectedSensors.Name = "lblConnectedSensors";
            this.lblConnectedSensors.Size = new System.Drawing.Size(100, 13);
            this.lblConnectedSensors.TabIndex = 1;
            this.lblConnectedSensors.Text = "Connected Sensors";
            // 
            // picVideoDisplay
            // 
            this.picVideoDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVideoDisplay.Location = new System.Drawing.Point(12, 12);
            this.picVideoDisplay.Name = "picVideoDisplay";
            this.picVideoDisplay.Size = new System.Drawing.Size(640, 480);
            this.picVideoDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picVideoDisplay.TabIndex = 2;
            this.picVideoDisplay.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 580);
            this.Controls.Add(this.picVideoDisplay);
            this.Controls.Add(this.grbSensor);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Kinect Camera Viewer";
            this.grbSensor.ResumeLayout(false);
            this.grbSensor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideoDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSensors;
        private System.Windows.Forms.GroupBox grbSensor;
        private System.Windows.Forms.Button btnActivateSensor;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblConnectedSensors;
        private System.Windows.Forms.PictureBox picVideoDisplay;
        private System.Windows.Forms.ComboBox cmbDisplayMode;
    }
}


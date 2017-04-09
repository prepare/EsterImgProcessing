namespace ImageBlending
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
            this.picSource = new System.Windows.Forms.PictureBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblOverlayImage = new System.Windows.Forms.Label();
            this.picOverlay = new System.Windows.Forms.PictureBox();
            this.btnLoadSourceImage = new System.Windows.Forms.Button();
            this.btnLoadOverlayImage = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.grbSource = new System.Windows.Forms.GroupBox();
            this.grnSourceLevels = new System.Windows.Forms.GroupBox();
            this.lblSourceLevelRed = new System.Windows.Forms.Label();
            this.trcSourceRedLevel = new System.Windows.Forms.TrackBar();
            this.lblSourceLevelGreen = new System.Windows.Forms.Label();
            this.trcSourceGreenLevel = new System.Windows.Forms.TrackBar();
            this.lblSourceLevelBlue = new System.Windows.Forms.Label();
            this.trcSourceBlueLevel = new System.Windows.Forms.TrackBar();
            this.grbSourceEnabledComponents = new System.Windows.Forms.GroupBox();
            this.chkEnableSourceRed = new System.Windows.Forms.CheckBox();
            this.chkEnableSourceGreen = new System.Windows.Forms.CheckBox();
            this.chkEnableSourceBlue = new System.Windows.Forms.CheckBox();
            this.grbOverlayImage = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOverlayLevelRed = new System.Windows.Forms.Label();
            this.trcOverlayRedLevel = new System.Windows.Forms.TrackBar();
            this.lblOverlayLevelGreen = new System.Windows.Forms.Label();
            this.trcOverlayGreenLevel = new System.Windows.Forms.TrackBar();
            this.lblOverlayLevelBlue = new System.Windows.Forms.Label();
            this.trcOverlayBlueLevel = new System.Windows.Forms.TrackBar();
            this.grbOverlayEnabledComponents = new System.Windows.Forms.GroupBox();
            this.chkEnableOverlayRed = new System.Windows.Forms.CheckBox();
            this.chkEnableOverlayGreen = new System.Windows.Forms.CheckBox();
            this.chkEnableOverlayBlue = new System.Windows.Forms.CheckBox();
            this.cmbBlendTypeRed = new System.Windows.Forms.ComboBox();
            this.lblBlendMethod = new System.Windows.Forms.Label();
            this.btnSaveBlendResult = new System.Windows.Forms.Button();
            this.lblBlendTypeRed = new System.Windows.Forms.Label();
            this.lblBlendTypeBlue = new System.Windows.Forms.Label();
            this.cmbBlendTypeBlue = new System.Windows.Forms.ComboBox();
            this.lblBlendTypeGreen = new System.Windows.Forms.Label();
            this.cmbBlendTypeGreen = new System.Windows.Forms.ComboBox();
            this.btnSaveFilter = new System.Windows.Forms.Button();
            this.btnLoadFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.grbSource.SuspendLayout();
            this.grnSourceLevels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcSourceRedLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSourceGreenLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSourceBlueLevel)).BeginInit();
            this.grbSourceEnabledComponents.SuspendLayout();
            this.grbOverlayImage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcOverlayRedLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcOverlayGreenLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcOverlayBlueLevel)).BeginInit();
            this.grbOverlayEnabledComponents.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSource
            // 
            this.picSource.BackColor = System.Drawing.Color.Silver;
            this.picSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Location = new System.Drawing.Point(15, 55);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(200, 200);
            this.picSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSource.TabIndex = 0;
            this.picSource.TabStop = false;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSource.Location = new System.Drawing.Point(11, 3);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(121, 20);
            this.lblSource.TabIndex = 1;
            this.lblSource.Text = "Source Image";
            // 
            // lblOverlayImage
            // 
            this.lblOverlayImage.AutoSize = true;
            this.lblOverlayImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverlayImage.Location = new System.Drawing.Point(12, 262);
            this.lblOverlayImage.Name = "lblOverlayImage";
            this.lblOverlayImage.Size = new System.Drawing.Size(123, 20);
            this.lblOverlayImage.TabIndex = 3;
            this.lblOverlayImage.Text = "Overlay Image";
            // 
            // picOverlay
            // 
            this.picOverlay.BackColor = System.Drawing.Color.Silver;
            this.picOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picOverlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOverlay.Location = new System.Drawing.Point(15, 312);
            this.picOverlay.Name = "picOverlay";
            this.picOverlay.Size = new System.Drawing.Size(200, 200);
            this.picOverlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOverlay.TabIndex = 2;
            this.picOverlay.TabStop = false;
            // 
            // btnLoadSourceImage
            // 
            this.btnLoadSourceImage.Location = new System.Drawing.Point(15, 26);
            this.btnLoadSourceImage.Name = "btnLoadSourceImage";
            this.btnLoadSourceImage.Size = new System.Drawing.Size(200, 23);
            this.btnLoadSourceImage.TabIndex = 4;
            this.btnLoadSourceImage.Text = "Load";
            this.btnLoadSourceImage.UseVisualStyleBackColor = true;
            this.btnLoadSourceImage.Click += new System.EventHandler(this.BtnLoadSourceImageClickEventHandler);
            // 
            // btnLoadOverlayImage
            // 
            this.btnLoadOverlayImage.Location = new System.Drawing.Point(15, 285);
            this.btnLoadOverlayImage.Name = "btnLoadOverlayImage";
            this.btnLoadOverlayImage.Size = new System.Drawing.Size(200, 23);
            this.btnLoadOverlayImage.TabIndex = 5;
            this.btnLoadOverlayImage.Text = "Load";
            this.btnLoadOverlayImage.UseVisualStyleBackColor = true;
            this.btnLoadOverlayImage.Click += new System.EventHandler(this.BtnOverlayImageClickEventHandler);
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.Silver;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Location = new System.Drawing.Point(240, 12);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(500, 500);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 6;
            this.picResult.TabStop = false;
            // 
            // grbSource
            // 
            this.grbSource.Controls.Add(this.grnSourceLevels);
            this.grbSource.Controls.Add(this.grbSourceEnabledComponents);
            this.grbSource.Location = new System.Drawing.Point(762, 12);
            this.grbSource.Name = "grbSource";
            this.grbSource.Size = new System.Drawing.Size(280, 248);
            this.grbSource.TabIndex = 7;
            this.grbSource.TabStop = false;
            this.grbSource.Text = "Source Image";
            // 
            // grnSourceLevels
            // 
            this.grnSourceLevels.Controls.Add(this.lblSourceLevelRed);
            this.grnSourceLevels.Controls.Add(this.trcSourceRedLevel);
            this.grnSourceLevels.Controls.Add(this.lblSourceLevelGreen);
            this.grnSourceLevels.Controls.Add(this.trcSourceGreenLevel);
            this.grnSourceLevels.Controls.Add(this.lblSourceLevelBlue);
            this.grnSourceLevels.Controls.Add(this.trcSourceBlueLevel);
            this.grnSourceLevels.Location = new System.Drawing.Point(11, 64);
            this.grnSourceLevels.Margin = new System.Windows.Forms.Padding(8);
            this.grnSourceLevels.Name = "grnSourceLevels";
            this.grnSourceLevels.Size = new System.Drawing.Size(246, 175);
            this.grnSourceLevels.TabIndex = 1;
            this.grnSourceLevels.TabStop = false;
            this.grnSourceLevels.Text = "Colours Levels";
            // 
            // lblSourceLevelRed
            // 
            this.lblSourceLevelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceLevelRed.Location = new System.Drawing.Point(172, 14);
            this.lblSourceLevelRed.Name = "lblSourceLevelRed";
            this.lblSourceLevelRed.Size = new System.Drawing.Size(68, 30);
            this.lblSourceLevelRed.TabIndex = 5;
            this.lblSourceLevelRed.Text = "R: 100%";
            this.lblSourceLevelRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trcSourceRedLevel
            // 
            this.trcSourceRedLevel.AutoSize = false;
            this.trcSourceRedLevel.BackColor = System.Drawing.Color.Silver;
            this.trcSourceRedLevel.Location = new System.Drawing.Point(176, 47);
            this.trcSourceRedLevel.Maximum = 200;
            this.trcSourceRedLevel.Minimum = -100;
            this.trcSourceRedLevel.Name = "trcSourceRedLevel";
            this.trcSourceRedLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcSourceRedLevel.Size = new System.Drawing.Size(48, 123);
            this.trcSourceRedLevel.TabIndex = 4;
            this.trcSourceRedLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcSourceRedLevel.Value = 100;
            this.trcSourceRedLevel.ValueChanged += new System.EventHandler(this.ColourLevelChangedEventHandler);
            // 
            // lblSourceLevelGreen
            // 
            this.lblSourceLevelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceLevelGreen.Location = new System.Drawing.Point(90, 14);
            this.lblSourceLevelGreen.Name = "lblSourceLevelGreen";
            this.lblSourceLevelGreen.Size = new System.Drawing.Size(76, 30);
            this.lblSourceLevelGreen.TabIndex = 3;
            this.lblSourceLevelGreen.Text = "G: 100%";
            this.lblSourceLevelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trcSourceGreenLevel
            // 
            this.trcSourceGreenLevel.AutoSize = false;
            this.trcSourceGreenLevel.BackColor = System.Drawing.Color.Silver;
            this.trcSourceGreenLevel.Location = new System.Drawing.Point(94, 47);
            this.trcSourceGreenLevel.Maximum = 200;
            this.trcSourceGreenLevel.Minimum = -100;
            this.trcSourceGreenLevel.Name = "trcSourceGreenLevel";
            this.trcSourceGreenLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcSourceGreenLevel.Size = new System.Drawing.Size(48, 123);
            this.trcSourceGreenLevel.TabIndex = 2;
            this.trcSourceGreenLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcSourceGreenLevel.Value = 100;
            this.trcSourceGreenLevel.ValueChanged += new System.EventHandler(this.ColourLevelChangedEventHandler);
            // 
            // lblSourceLevelBlue
            // 
            this.lblSourceLevelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSourceLevelBlue.Location = new System.Drawing.Point(6, 14);
            this.lblSourceLevelBlue.Name = "lblSourceLevelBlue";
            this.lblSourceLevelBlue.Size = new System.Drawing.Size(78, 30);
            this.lblSourceLevelBlue.TabIndex = 1;
            this.lblSourceLevelBlue.Text = "B: 100%";
            this.lblSourceLevelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trcSourceBlueLevel
            // 
            this.trcSourceBlueLevel.AutoSize = false;
            this.trcSourceBlueLevel.BackColor = System.Drawing.Color.Silver;
            this.trcSourceBlueLevel.Location = new System.Drawing.Point(10, 47);
            this.trcSourceBlueLevel.Maximum = 200;
            this.trcSourceBlueLevel.Minimum = -100;
            this.trcSourceBlueLevel.Name = "trcSourceBlueLevel";
            this.trcSourceBlueLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcSourceBlueLevel.Size = new System.Drawing.Size(48, 123);
            this.trcSourceBlueLevel.TabIndex = 0;
            this.trcSourceBlueLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcSourceBlueLevel.Value = 100;
            this.trcSourceBlueLevel.ValueChanged += new System.EventHandler(this.ColourLevelChangedEventHandler);
            // 
            // grbSourceEnabledComponents
            // 
            this.grbSourceEnabledComponents.Controls.Add(this.chkEnableSourceRed);
            this.grbSourceEnabledComponents.Controls.Add(this.chkEnableSourceGreen);
            this.grbSourceEnabledComponents.Controls.Add(this.chkEnableSourceBlue);
            this.grbSourceEnabledComponents.Location = new System.Drawing.Point(11, 19);
            this.grbSourceEnabledComponents.Margin = new System.Windows.Forms.Padding(8);
            this.grbSourceEnabledComponents.Name = "grbSourceEnabledComponents";
            this.grbSourceEnabledComponents.Size = new System.Drawing.Size(246, 43);
            this.grbSourceEnabledComponents.TabIndex = 0;
            this.grbSourceEnabledComponents.TabStop = false;
            this.grbSourceEnabledComponents.Text = "Enable/Disable Colours";
            // 
            // chkEnableSourceRed
            // 
            this.chkEnableSourceRed.AutoSize = true;
            this.chkEnableSourceRed.Checked = true;
            this.chkEnableSourceRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSourceRed.Location = new System.Drawing.Point(175, 19);
            this.chkEnableSourceRed.Name = "chkEnableSourceRed";
            this.chkEnableSourceRed.Size = new System.Drawing.Size(46, 17);
            this.chkEnableSourceRed.TabIndex = 2;
            this.chkEnableSourceRed.Text = "Red";
            this.chkEnableSourceRed.UseVisualStyleBackColor = true;
            this.chkEnableSourceRed.CheckedChanged += new System.EventHandler(this.ColorCheckedChangedEventHandler);
            // 
            // chkEnableSourceGreen
            // 
            this.chkEnableSourceGreen.AutoSize = true;
            this.chkEnableSourceGreen.Checked = true;
            this.chkEnableSourceGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSourceGreen.Location = new System.Drawing.Point(93, 20);
            this.chkEnableSourceGreen.Name = "chkEnableSourceGreen";
            this.chkEnableSourceGreen.Size = new System.Drawing.Size(55, 17);
            this.chkEnableSourceGreen.TabIndex = 1;
            this.chkEnableSourceGreen.Text = "Green";
            this.chkEnableSourceGreen.UseVisualStyleBackColor = true;
            this.chkEnableSourceGreen.CheckedChanged += new System.EventHandler(this.ColorCheckedChangedEventHandler);
            // 
            // chkEnableSourceBlue
            // 
            this.chkEnableSourceBlue.AutoSize = true;
            this.chkEnableSourceBlue.Checked = true;
            this.chkEnableSourceBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableSourceBlue.Location = new System.Drawing.Point(9, 20);
            this.chkEnableSourceBlue.Name = "chkEnableSourceBlue";
            this.chkEnableSourceBlue.Size = new System.Drawing.Size(47, 17);
            this.chkEnableSourceBlue.TabIndex = 0;
            this.chkEnableSourceBlue.Text = "Blue";
            this.chkEnableSourceBlue.UseVisualStyleBackColor = true;
            this.chkEnableSourceBlue.CheckedChanged += new System.EventHandler(this.ColorCheckedChangedEventHandler);
            // 
            // grbOverlayImage
            // 
            this.grbOverlayImage.Controls.Add(this.groupBox2);
            this.grbOverlayImage.Controls.Add(this.grbOverlayEnabledComponents);
            this.grbOverlayImage.Location = new System.Drawing.Point(762, 266);
            this.grbOverlayImage.Name = "grbOverlayImage";
            this.grbOverlayImage.Size = new System.Drawing.Size(280, 248);
            this.grbOverlayImage.TabIndex = 8;
            this.grbOverlayImage.TabStop = false;
            this.grbOverlayImage.Text = "Overlay Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOverlayLevelRed);
            this.groupBox2.Controls.Add(this.trcOverlayRedLevel);
            this.groupBox2.Controls.Add(this.lblOverlayLevelGreen);
            this.groupBox2.Controls.Add(this.trcOverlayGreenLevel);
            this.groupBox2.Controls.Add(this.lblOverlayLevelBlue);
            this.groupBox2.Controls.Add(this.trcOverlayBlueLevel);
            this.groupBox2.Location = new System.Drawing.Point(11, 64);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Colours Levels";
            // 
            // lblOverlayLevelRed
            // 
            this.lblOverlayLevelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverlayLevelRed.Location = new System.Drawing.Point(172, 14);
            this.lblOverlayLevelRed.Name = "lblOverlayLevelRed";
            this.lblOverlayLevelRed.Size = new System.Drawing.Size(68, 30);
            this.lblOverlayLevelRed.TabIndex = 5;
            this.lblOverlayLevelRed.Text = "R: 25%";
            this.lblOverlayLevelRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trcOverlayRedLevel
            // 
            this.trcOverlayRedLevel.AutoSize = false;
            this.trcOverlayRedLevel.BackColor = System.Drawing.Color.Silver;
            this.trcOverlayRedLevel.Location = new System.Drawing.Point(176, 47);
            this.trcOverlayRedLevel.Maximum = 200;
            this.trcOverlayRedLevel.Minimum = -100;
            this.trcOverlayRedLevel.Name = "trcOverlayRedLevel";
            this.trcOverlayRedLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcOverlayRedLevel.Size = new System.Drawing.Size(48, 123);
            this.trcOverlayRedLevel.TabIndex = 4;
            this.trcOverlayRedLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcOverlayRedLevel.Value = 25;
            this.trcOverlayRedLevel.ValueChanged += new System.EventHandler(this.ColourLevelChangedEventHandler);
            // 
            // lblOverlayLevelGreen
            // 
            this.lblOverlayLevelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverlayLevelGreen.Location = new System.Drawing.Point(90, 14);
            this.lblOverlayLevelGreen.Name = "lblOverlayLevelGreen";
            this.lblOverlayLevelGreen.Size = new System.Drawing.Size(76, 30);
            this.lblOverlayLevelGreen.TabIndex = 3;
            this.lblOverlayLevelGreen.Text = "G: 25%";
            this.lblOverlayLevelGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trcOverlayGreenLevel
            // 
            this.trcOverlayGreenLevel.AutoSize = false;
            this.trcOverlayGreenLevel.BackColor = System.Drawing.Color.Silver;
            this.trcOverlayGreenLevel.Location = new System.Drawing.Point(94, 47);
            this.trcOverlayGreenLevel.Maximum = 200;
            this.trcOverlayGreenLevel.Minimum = -100;
            this.trcOverlayGreenLevel.Name = "trcOverlayGreenLevel";
            this.trcOverlayGreenLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcOverlayGreenLevel.Size = new System.Drawing.Size(48, 123);
            this.trcOverlayGreenLevel.TabIndex = 2;
            this.trcOverlayGreenLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcOverlayGreenLevel.Value = 25;
            this.trcOverlayGreenLevel.ValueChanged += new System.EventHandler(this.ColourLevelChangedEventHandler);
            // 
            // lblOverlayLevelBlue
            // 
            this.lblOverlayLevelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverlayLevelBlue.Location = new System.Drawing.Point(6, 14);
            this.lblOverlayLevelBlue.Name = "lblOverlayLevelBlue";
            this.lblOverlayLevelBlue.Size = new System.Drawing.Size(78, 30);
            this.lblOverlayLevelBlue.TabIndex = 1;
            this.lblOverlayLevelBlue.Text = "B: 25%";
            this.lblOverlayLevelBlue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // trcOverlayBlueLevel
            // 
            this.trcOverlayBlueLevel.AutoSize = false;
            this.trcOverlayBlueLevel.BackColor = System.Drawing.Color.Silver;
            this.trcOverlayBlueLevel.Location = new System.Drawing.Point(10, 47);
            this.trcOverlayBlueLevel.Maximum = 200;
            this.trcOverlayBlueLevel.Minimum = -100;
            this.trcOverlayBlueLevel.Name = "trcOverlayBlueLevel";
            this.trcOverlayBlueLevel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trcOverlayBlueLevel.Size = new System.Drawing.Size(48, 123);
            this.trcOverlayBlueLevel.TabIndex = 0;
            this.trcOverlayBlueLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trcOverlayBlueLevel.Value = 25;
            this.trcOverlayBlueLevel.ValueChanged += new System.EventHandler(this.ColourLevelChangedEventHandler);
            // 
            // grbOverlayEnabledComponents
            // 
            this.grbOverlayEnabledComponents.Controls.Add(this.chkEnableOverlayRed);
            this.grbOverlayEnabledComponents.Controls.Add(this.chkEnableOverlayGreen);
            this.grbOverlayEnabledComponents.Controls.Add(this.chkEnableOverlayBlue);
            this.grbOverlayEnabledComponents.Location = new System.Drawing.Point(11, 19);
            this.grbOverlayEnabledComponents.Margin = new System.Windows.Forms.Padding(8);
            this.grbOverlayEnabledComponents.Name = "grbOverlayEnabledComponents";
            this.grbOverlayEnabledComponents.Size = new System.Drawing.Size(246, 43);
            this.grbOverlayEnabledComponents.TabIndex = 0;
            this.grbOverlayEnabledComponents.TabStop = false;
            this.grbOverlayEnabledComponents.Text = "Enable/Disable Colours";
            // 
            // chkEnableOverlayRed
            // 
            this.chkEnableOverlayRed.AutoSize = true;
            this.chkEnableOverlayRed.Checked = true;
            this.chkEnableOverlayRed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableOverlayRed.Location = new System.Drawing.Point(175, 19);
            this.chkEnableOverlayRed.Name = "chkEnableOverlayRed";
            this.chkEnableOverlayRed.Size = new System.Drawing.Size(46, 17);
            this.chkEnableOverlayRed.TabIndex = 2;
            this.chkEnableOverlayRed.Text = "Red";
            this.chkEnableOverlayRed.UseVisualStyleBackColor = true;
            this.chkEnableOverlayRed.CheckedChanged += new System.EventHandler(this.ColorCheckedChangedEventHandler);
            // 
            // chkEnableOverlayGreen
            // 
            this.chkEnableOverlayGreen.AutoSize = true;
            this.chkEnableOverlayGreen.Checked = true;
            this.chkEnableOverlayGreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableOverlayGreen.Location = new System.Drawing.Point(93, 20);
            this.chkEnableOverlayGreen.Name = "chkEnableOverlayGreen";
            this.chkEnableOverlayGreen.Size = new System.Drawing.Size(55, 17);
            this.chkEnableOverlayGreen.TabIndex = 1;
            this.chkEnableOverlayGreen.Text = "Green";
            this.chkEnableOverlayGreen.UseVisualStyleBackColor = true;
            this.chkEnableOverlayGreen.CheckedChanged += new System.EventHandler(this.ColorCheckedChangedEventHandler);
            // 
            // chkEnableOverlayBlue
            // 
            this.chkEnableOverlayBlue.AutoSize = true;
            this.chkEnableOverlayBlue.Checked = true;
            this.chkEnableOverlayBlue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableOverlayBlue.Location = new System.Drawing.Point(9, 20);
            this.chkEnableOverlayBlue.Name = "chkEnableOverlayBlue";
            this.chkEnableOverlayBlue.Size = new System.Drawing.Size(47, 17);
            this.chkEnableOverlayBlue.TabIndex = 0;
            this.chkEnableOverlayBlue.Text = "Blue";
            this.chkEnableOverlayBlue.UseVisualStyleBackColor = true;
            this.chkEnableOverlayBlue.CheckedChanged += new System.EventHandler(this.ColorCheckedChangedEventHandler);
            // 
            // cmbBlendTypeRed
            // 
            this.cmbBlendTypeRed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlendTypeRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlendTypeRed.FormattingEnabled = true;
            this.cmbBlendTypeRed.Location = new System.Drawing.Point(954, 537);
            this.cmbBlendTypeRed.Name = "cmbBlendTypeRed";
            this.cmbBlendTypeRed.Size = new System.Drawing.Size(90, 21);
            this.cmbBlendTypeRed.TabIndex = 9;
            this.cmbBlendTypeRed.SelectedIndexChanged += new System.EventHandler(this.ImageBlendMethodChangedEventHandler);
            // 
            // lblBlendMethod
            // 
            this.lblBlendMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlendMethod.Location = new System.Drawing.Point(493, 520);
            this.lblBlendMethod.Name = "lblBlendMethod";
            this.lblBlendMethod.Size = new System.Drawing.Size(247, 46);
            this.lblBlendMethod.TabIndex = 10;
            this.lblBlendMethod.Text = "Image Blend Method:";
            this.lblBlendMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSaveBlendResult
            // 
            this.btnSaveBlendResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveBlendResult.Location = new System.Drawing.Point(16, 517);
            this.btnSaveBlendResult.Name = "btnSaveBlendResult";
            this.btnSaveBlendResult.Size = new System.Drawing.Size(200, 45);
            this.btnSaveBlendResult.TabIndex = 11;
            this.btnSaveBlendResult.Text = "Save Image";
            this.btnSaveBlendResult.UseVisualStyleBackColor = true;
            this.btnSaveBlendResult.Click += new System.EventHandler(this.btnSaveBlendResult_Click);
            // 
            // lblBlendTypeRed
            // 
            this.lblBlendTypeRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlendTypeRed.Location = new System.Drawing.Point(954, 517);
            this.lblBlendTypeRed.Name = "lblBlendTypeRed";
            this.lblBlendTypeRed.Size = new System.Drawing.Size(88, 17);
            this.lblBlendTypeRed.TabIndex = 12;
            this.lblBlendTypeRed.Text = "Red";
            this.lblBlendTypeRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlendTypeBlue
            // 
            this.lblBlendTypeBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlendTypeBlue.Location = new System.Drawing.Point(759, 517);
            this.lblBlendTypeBlue.Name = "lblBlendTypeBlue";
            this.lblBlendTypeBlue.Size = new System.Drawing.Size(93, 17);
            this.lblBlendTypeBlue.TabIndex = 14;
            this.lblBlendTypeBlue.Text = "Blue";
            this.lblBlendTypeBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBlendTypeBlue
            // 
            this.cmbBlendTypeBlue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlendTypeBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlendTypeBlue.FormattingEnabled = true;
            this.cmbBlendTypeBlue.Location = new System.Drawing.Point(762, 537);
            this.cmbBlendTypeBlue.Name = "cmbBlendTypeBlue";
            this.cmbBlendTypeBlue.Size = new System.Drawing.Size(90, 21);
            this.cmbBlendTypeBlue.TabIndex = 13;
            this.cmbBlendTypeBlue.SelectedIndexChanged += new System.EventHandler(this.ImageBlendMethodChangedEventHandler);
            // 
            // lblBlendTypeGreen
            // 
            this.lblBlendTypeGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlendTypeGreen.Location = new System.Drawing.Point(856, 517);
            this.lblBlendTypeGreen.Name = "lblBlendTypeGreen";
            this.lblBlendTypeGreen.Size = new System.Drawing.Size(92, 17);
            this.lblBlendTypeGreen.TabIndex = 16;
            this.lblBlendTypeGreen.Text = "Green";
            this.lblBlendTypeGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBlendTypeGreen
            // 
            this.cmbBlendTypeGreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBlendTypeGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBlendTypeGreen.FormattingEnabled = true;
            this.cmbBlendTypeGreen.Location = new System.Drawing.Point(858, 537);
            this.cmbBlendTypeGreen.Name = "cmbBlendTypeGreen";
            this.cmbBlendTypeGreen.Size = new System.Drawing.Size(90, 21);
            this.cmbBlendTypeGreen.TabIndex = 15;
            this.cmbBlendTypeGreen.SelectedIndexChanged += new System.EventHandler(this.ImageBlendMethodChangedEventHandler);
            // 
            // btnSaveFilter
            // 
            this.btnSaveFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFilter.Location = new System.Drawing.Point(240, 517);
            this.btnSaveFilter.Name = "btnSaveFilter";
            this.btnSaveFilter.Size = new System.Drawing.Size(110, 45);
            this.btnSaveFilter.TabIndex = 17;
            this.btnSaveFilter.Text = "Save Filter";
            this.btnSaveFilter.UseVisualStyleBackColor = true;
            this.btnSaveFilter.Click += new System.EventHandler(this.btnSaveFilter_Click);
            // 
            // btnLoadFilter
            // 
            this.btnLoadFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFilter.Location = new System.Drawing.Point(356, 518);
            this.btnLoadFilter.Name = "btnLoadFilter";
            this.btnLoadFilter.Size = new System.Drawing.Size(110, 44);
            this.btnLoadFilter.TabIndex = 18;
            this.btnLoadFilter.Text = "Load Filter";
            this.btnLoadFilter.UseVisualStyleBackColor = true;
            this.btnLoadFilter.Click += new System.EventHandler(this.btnLoadFilter_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1054, 569);
            this.Controls.Add(this.btnLoadFilter);
            this.Controls.Add(this.btnSaveFilter);
            this.Controls.Add(this.lblBlendTypeGreen);
            this.Controls.Add(this.cmbBlendTypeGreen);
            this.Controls.Add(this.lblBlendTypeBlue);
            this.Controls.Add(this.cmbBlendTypeBlue);
            this.Controls.Add(this.lblBlendTypeRed);
            this.Controls.Add(this.btnSaveBlendResult);
            this.Controls.Add(this.lblBlendMethod);
            this.Controls.Add(this.cmbBlendTypeRed);
            this.Controls.Add(this.grbOverlayImage);
            this.Controls.Add(this.grbSource);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.btnLoadOverlayImage);
            this.Controls.Add(this.btnLoadSourceImage);
            this.Controls.Add(this.lblOverlayImage);
            this.Controls.Add(this.picOverlay);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.picSource);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overlay Bitmap Blending in C#";
            ((System.ComponentModel.ISupportInitialize)(this.picSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.grbSource.ResumeLayout(false);
            this.grnSourceLevels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcSourceRedLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSourceGreenLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcSourceBlueLevel)).EndInit();
            this.grbSourceEnabledComponents.ResumeLayout(false);
            this.grbSourceEnabledComponents.PerformLayout();
            this.grbOverlayImage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcOverlayRedLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcOverlayGreenLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcOverlayBlueLevel)).EndInit();
            this.grbOverlayEnabledComponents.ResumeLayout(false);
            this.grbOverlayEnabledComponents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSource;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblOverlayImage;
        private System.Windows.Forms.PictureBox picOverlay;
        private System.Windows.Forms.Button btnLoadSourceImage;
        private System.Windows.Forms.Button btnLoadOverlayImage;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.GroupBox grbSource;
        private System.Windows.Forms.GroupBox grbSourceEnabledComponents;
        private System.Windows.Forms.CheckBox chkEnableSourceRed;
        private System.Windows.Forms.CheckBox chkEnableSourceGreen;
        private System.Windows.Forms.CheckBox chkEnableSourceBlue;
        private System.Windows.Forms.GroupBox grnSourceLevels;
        private System.Windows.Forms.Label lblSourceLevelBlue;
        private System.Windows.Forms.TrackBar trcSourceBlueLevel;
        private System.Windows.Forms.Label lblSourceLevelRed;
        private System.Windows.Forms.TrackBar trcSourceRedLevel;
        private System.Windows.Forms.Label lblSourceLevelGreen;
        private System.Windows.Forms.TrackBar trcSourceGreenLevel;
        private System.Windows.Forms.GroupBox grbOverlayImage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOverlayLevelRed;
        private System.Windows.Forms.TrackBar trcOverlayRedLevel;
        private System.Windows.Forms.Label lblOverlayLevelGreen;
        private System.Windows.Forms.TrackBar trcOverlayGreenLevel;
        private System.Windows.Forms.Label lblOverlayLevelBlue;
        private System.Windows.Forms.TrackBar trcOverlayBlueLevel;
        private System.Windows.Forms.GroupBox grbOverlayEnabledComponents;
        private System.Windows.Forms.CheckBox chkEnableOverlayRed;
        private System.Windows.Forms.CheckBox chkEnableOverlayGreen;
        private System.Windows.Forms.CheckBox chkEnableOverlayBlue;
        private System.Windows.Forms.ComboBox cmbBlendTypeRed;
        private System.Windows.Forms.Label lblBlendMethod;
        private System.Windows.Forms.Button btnSaveBlendResult;
        private System.Windows.Forms.Label lblBlendTypeRed;
        private System.Windows.Forms.Label lblBlendTypeBlue;
        private System.Windows.Forms.ComboBox cmbBlendTypeBlue;
        private System.Windows.Forms.Label lblBlendTypeGreen;
        private System.Windows.Forms.ComboBox cmbBlendTypeGreen;
        private System.Windows.Forms.Button btnSaveFilter;
        private System.Windows.Forms.Button btnLoadFilter;
    }
}


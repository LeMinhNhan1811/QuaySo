namespace QuaySo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.font3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOutlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorShadowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorWhenSelectingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFillToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOutlineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorShadowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPreviousOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSelectingSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWinSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFileStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonSet = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.buttonSetSpeed = new System.Windows.Forms.Button();
            this.txtBoxSpeed = new System.Windows.Forms.TextBox();
            this.txtBoxLasttimeSlowDown = new System.Windows.Forms.TextBox();
            this.buttonSetSlownDown = new System.Windows.Forms.Button();
            this.labelLastshowTime = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnNewSpin = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtBoxOutLineStrength = new QuaySo.NumericTextBox();
            this.drawShape3 = new CzaryText.Control.DrawShape();
            this.drawShape2 = new CzaryText.Control.DrawShape();
            this.drawShape1 = new CzaryText.Control.DrawShape();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.font2ToolStripMenuItem,
            this.font3ToolStripMenuItem,
            this.mainColorToolStripMenuItem,
            this.colorWhenSelectingToolStripMenuItem,
            this.loadBackgroundToolStripMenuItem,
            this.saveOptionToolStripMenuItem,
            this.loadPreviousOptionToolStripMenuItem,
            this.loadSelectingSoundToolStripMenuItem,
            this.loadWinSoundToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // font2ToolStripMenuItem
            // 
            this.font2ToolStripMenuItem.Name = "font2ToolStripMenuItem";
            this.font2ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.font2ToolStripMenuItem.Text = "Font 2";
            this.font2ToolStripMenuItem.Click += new System.EventHandler(this.font2ToolStripMenuItem_Click);
            // 
            // font3ToolStripMenuItem
            // 
            this.font3ToolStripMenuItem.Name = "font3ToolStripMenuItem";
            this.font3ToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.font3ToolStripMenuItem.Text = "Font 3";
            this.font3ToolStripMenuItem.Click += new System.EventHandler(this.font3ToolStripMenuItem_Click);
            // 
            // mainColorToolStripMenuItem
            // 
            this.mainColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorFillToolStripMenuItem,
            this.colorOutlineToolStripMenuItem,
            this.colorShadowToolStripMenuItem});
            this.mainColorToolStripMenuItem.Name = "mainColorToolStripMenuItem";
            this.mainColorToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.mainColorToolStripMenuItem.Text = "Main Color";
            // 
            // colorFillToolStripMenuItem
            // 
            this.colorFillToolStripMenuItem.Name = "colorFillToolStripMenuItem";
            this.colorFillToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.colorFillToolStripMenuItem.Text = "Color Fill";
            this.colorFillToolStripMenuItem.Click += new System.EventHandler(this.colorFillToolStripMenuItem_Click_1);
            // 
            // colorOutlineToolStripMenuItem
            // 
            this.colorOutlineToolStripMenuItem.Name = "colorOutlineToolStripMenuItem";
            this.colorOutlineToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.colorOutlineToolStripMenuItem.Text = "Color Outline";
            this.colorOutlineToolStripMenuItem.Click += new System.EventHandler(this.colorOutlineToolStripMenuItem_Click_1);
            // 
            // colorShadowToolStripMenuItem
            // 
            this.colorShadowToolStripMenuItem.Name = "colorShadowToolStripMenuItem";
            this.colorShadowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.colorShadowToolStripMenuItem.Text = "Color Shadow";
            this.colorShadowToolStripMenuItem.Click += new System.EventHandler(this.colorShadowToolStripMenuItem_Click_1);
            // 
            // colorWhenSelectingToolStripMenuItem
            // 
            this.colorWhenSelectingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorFillToolStripMenuItem1,
            this.colorOutlineToolStripMenuItem1,
            this.colorShadowToolStripMenuItem1});
            this.colorWhenSelectingToolStripMenuItem.Name = "colorWhenSelectingToolStripMenuItem";
            this.colorWhenSelectingToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.colorWhenSelectingToolStripMenuItem.Text = "Selecting Color";
            // 
            // colorFillToolStripMenuItem1
            // 
            this.colorFillToolStripMenuItem1.Name = "colorFillToolStripMenuItem1";
            this.colorFillToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.colorFillToolStripMenuItem1.Text = "Color Fill";
            this.colorFillToolStripMenuItem1.Click += new System.EventHandler(this.colorFillToolStripMenuItem1_Click);
            // 
            // colorOutlineToolStripMenuItem1
            // 
            this.colorOutlineToolStripMenuItem1.Name = "colorOutlineToolStripMenuItem1";
            this.colorOutlineToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.colorOutlineToolStripMenuItem1.Text = "Color Outline";
            this.colorOutlineToolStripMenuItem1.Click += new System.EventHandler(this.colorOutlineToolStripMenuItem1_Click);
            // 
            // colorShadowToolStripMenuItem1
            // 
            this.colorShadowToolStripMenuItem1.Name = "colorShadowToolStripMenuItem1";
            this.colorShadowToolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.colorShadowToolStripMenuItem1.Text = "Color Shadow";
            this.colorShadowToolStripMenuItem1.Click += new System.EventHandler(this.colorShadowToolStripMenuItem1_Click);
            // 
            // loadBackgroundToolStripMenuItem
            // 
            this.loadBackgroundToolStripMenuItem.Name = "loadBackgroundToolStripMenuItem";
            this.loadBackgroundToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadBackgroundToolStripMenuItem.Text = "Load background";
            this.loadBackgroundToolStripMenuItem.Click += new System.EventHandler(this.loadBackgroundToolStripMenuItem_Click);
            // 
            // saveOptionToolStripMenuItem
            // 
            this.saveOptionToolStripMenuItem.Name = "saveOptionToolStripMenuItem";
            this.saveOptionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.saveOptionToolStripMenuItem.Text = "Save option";
            this.saveOptionToolStripMenuItem.Click += new System.EventHandler(this.saveOptionToolStripMenuItem_Click);
            // 
            // loadPreviousOptionToolStripMenuItem
            // 
            this.loadPreviousOptionToolStripMenuItem.Name = "loadPreviousOptionToolStripMenuItem";
            this.loadPreviousOptionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadPreviousOptionToolStripMenuItem.Text = "Load previous option";
            this.loadPreviousOptionToolStripMenuItem.Click += new System.EventHandler(this.loadPreviousOptionToolStripMenuItem_Click);
            // 
            // loadSelectingSoundToolStripMenuItem
            // 
            this.loadSelectingSoundToolStripMenuItem.Name = "loadSelectingSoundToolStripMenuItem";
            this.loadSelectingSoundToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadSelectingSoundToolStripMenuItem.Text = "Load Selecting Sound";
            this.loadSelectingSoundToolStripMenuItem.Click += new System.EventHandler(this.loadSelectingSoundToolStripMenuItem_Click);
            // 
            // loadWinSoundToolStripMenuItem
            // 
            this.loadWinSoundToolStripMenuItem.Name = "loadWinSoundToolStripMenuItem";
            this.loadWinSoundToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loadWinSoundToolStripMenuItem.Text = "Load Win Sound";
            this.loadWinSoundToolStripMenuItem.Click += new System.EventHandler(this.loadWinSoundToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.drawShape3);
            this.panel1.Controls.Add(this.drawShape2);
            this.panel1.Controls.Add(this.labelFileStatus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.drawShape1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 514);
            this.panel1.TabIndex = 3;
            // 
            // labelFileStatus
            // 
            this.labelFileStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileStatus.AutoSize = true;
            this.labelFileStatus.BackColor = System.Drawing.Color.White;
            this.labelFileStatus.Location = new System.Drawing.Point(759, 497);
            this.labelFileStatus.Name = "labelFileStatus";
            this.labelFileStatus.Size = new System.Drawing.Size(63, 13);
            this.labelFileStatus.TabIndex = 6;
            this.labelFileStatus.Text = "Not Loaded";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "STC Tân Cảng";
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSet.Location = new System.Drawing.Point(690, 2);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 21);
            this.buttonSet.TabIndex = 5;
            this.buttonSet.Text = "Set Outline";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // buttonSetSpeed
            // 
            this.buttonSetSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetSpeed.Location = new System.Drawing.Point(550, 2);
            this.buttonSetSpeed.Name = "buttonSetSpeed";
            this.buttonSetSpeed.Size = new System.Drawing.Size(75, 20);
            this.buttonSetSpeed.TabIndex = 7;
            this.buttonSetSpeed.Text = "Set Speed";
            this.buttonSetSpeed.UseVisualStyleBackColor = true;
            this.buttonSetSpeed.Click += new System.EventHandler(this.buttonSetSpeed_Click);
            // 
            // txtBoxSpeed
            // 
            this.txtBoxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSpeed.Location = new System.Drawing.Point(631, 2);
            this.txtBoxSpeed.Name = "txtBoxSpeed";
            this.txtBoxSpeed.Size = new System.Drawing.Size(53, 20);
            this.txtBoxSpeed.TabIndex = 9;
            // 
            // txtBoxLasttimeSlowDown
            // 
            this.txtBoxLasttimeSlowDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxLasttimeSlowDown.Location = new System.Drawing.Point(455, 2);
            this.txtBoxLasttimeSlowDown.Name = "txtBoxLasttimeSlowDown";
            this.txtBoxLasttimeSlowDown.Size = new System.Drawing.Size(72, 20);
            this.txtBoxLasttimeSlowDown.TabIndex = 10;
            // 
            // buttonSetSlownDown
            // 
            this.buttonSetSlownDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetSlownDown.Location = new System.Drawing.Point(331, 1);
            this.buttonSetSlownDown.Name = "buttonSetSlownDown";
            this.buttonSetSlownDown.Size = new System.Drawing.Size(118, 23);
            this.buttonSetSlownDown.TabIndex = 11;
            this.buttonSetSlownDown.Text = "Set Slow Down Time";
            this.buttonSetSlownDown.UseVisualStyleBackColor = true;
            this.buttonSetSlownDown.Click += new System.EventHandler(this.btnSetSlownDown_Click);
            // 
            // labelLastshowTime
            // 
            this.labelLastshowTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastshowTime.AutoSize = true;
            this.labelLastshowTime.Location = new System.Drawing.Point(529, 6);
            this.labelLastshowTime.Name = "labelLastshowTime";
            this.labelLastshowTime.Size = new System.Drawing.Size(20, 13);
            this.labelLastshowTime.TabIndex = 12;
            this.labelLastshowTime.Text = "ms";
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContinue.Location = new System.Drawing.Point(171, 1);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "Next Round";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnNewSpin
            // 
            this.btnNewSpin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewSpin.Location = new System.Drawing.Point(250, 1);
            this.btnNewSpin.Name = "btnNewSpin";
            this.btnNewSpin.Size = new System.Drawing.Size(75, 23);
            this.btnNewSpin.TabIndex = 10;
            this.btnNewSpin.Text = "New Spin";
            this.btnNewSpin.UseVisualStyleBackColor = true;
            this.btnNewSpin.Click += new System.EventHandler(this.btnNewSpin_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(110, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Hủy";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtBoxOutLineStrength
            // 
            this.txtBoxOutLineStrength.AllowSpace = false;
            this.txtBoxOutLineStrength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutLineStrength.Location = new System.Drawing.Point(769, 2);
            this.txtBoxOutLineStrength.Name = "txtBoxOutLineStrength";
            this.txtBoxOutLineStrength.Size = new System.Drawing.Size(55, 20);
            this.txtBoxOutLineStrength.TabIndex = 4;
            // 
            // drawShape3
            // 
            this.drawShape3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawShape3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawShape3.BackColor = System.Drawing.Color.Transparent;
            this.drawShape3.BoderColor = System.Drawing.Color.Black;
            this.drawShape3.BoderPenWidth = 2;
            this.drawShape3.Caption = "";
            this.drawShape3.FillColor = System.Drawing.Color.OrangeRed;
            this.drawShape3.FontName = "Microsoft Sans Serif";
            this.drawShape3.GradientColor = System.Drawing.Color.Transparent;
            this.drawShape3.Location = new System.Drawing.Point(20, 363);
            this.drawShape3.Name = "drawShape3";
            this.drawShape3.PenSize = 48;
            this.drawShape3.ShadowColor = System.Drawing.Color.Black;
            this.drawShape3.ShadowOpacity = 50;
            this.drawShape3.Size = new System.Drawing.Size(788, 109);
            this.drawShape3.TabIndex = 8;
            this.drawShape3.TextType = CzaryText.Control.TextType.Text3Outline;
            // 
            // drawShape2
            // 
            this.drawShape2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.drawShape2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawShape2.BackColor = System.Drawing.Color.Transparent;
            this.drawShape2.BoderColor = System.Drawing.Color.Black;
            this.drawShape2.BoderPenWidth = 2;
            this.drawShape2.Caption = "";
            this.drawShape2.FillColor = System.Drawing.Color.OrangeRed;
            this.drawShape2.FontName = "Microsoft Sans Serif";
            this.drawShape2.GradientColor = System.Drawing.Color.Transparent;
            this.drawShape2.Location = new System.Drawing.Point(17, 253);
            this.drawShape2.Name = "drawShape2";
            this.drawShape2.PenSize = 48;
            this.drawShape2.ShadowColor = System.Drawing.Color.Black;
            this.drawShape2.ShadowOpacity = 50;
            this.drawShape2.Size = new System.Drawing.Size(791, 113);
            this.drawShape2.TabIndex = 7;
            this.drawShape2.TextType = CzaryText.Control.TextType.Text3Outline;
            // 
            // drawShape1
            // 
            this.drawShape1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.drawShape1.BackColor = System.Drawing.Color.Transparent;
            this.drawShape1.BoderColor = System.Drawing.Color.Black;
            this.drawShape1.BoderPenWidth = 3;
            this.drawShape1.Caption = "";
            this.drawShape1.FillColor = System.Drawing.Color.DarkOrange;
            this.drawShape1.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawShape1.FontName = "Microsoft Sans Serif";
            this.drawShape1.GradientColor = System.Drawing.Color.Transparent;
            this.drawShape1.Location = new System.Drawing.Point(-1, 8);
            this.drawShape1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.drawShape1.Name = "drawShape1";
            this.drawShape1.PenSize = 100;
            this.drawShape1.ShadowColor = System.Drawing.Color.Black;
            this.drawShape1.ShadowOpacity = 50;
            this.drawShape1.Size = new System.Drawing.Size(791, 214);
            this.drawShape1.TabIndex = 2;
            this.drawShape1.TextType = CzaryText.Control.TextType.Text3Outline;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(825, 538);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnNewSpin);
            this.Controls.Add(this.labelLastshowTime);
            this.Controls.Add(this.buttonSetSlownDown);
            this.Controls.Add(this.txtBoxLasttimeSlowDown);
            this.Controls.Add(this.txtBoxSpeed);
            this.Controls.Add(this.buttonSetSpeed);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.txtBoxOutLineStrength);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quay số Tân Cảng";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private CzaryText.Control.DrawShape drawShape1;
        private System.Windows.Forms.ColorDialog colorDialog;
        private NumericTextBox txtBoxOutLineStrength;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelFileStatus;
        private System.Windows.Forms.ToolStripMenuItem loadBackgroundToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem colorWhenSelectingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFillToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorOutlineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem colorShadowToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOutlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorShadowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPreviousOptionToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button buttonSetSpeed;
        private System.Windows.Forms.TextBox txtBoxSpeed;
        private System.Windows.Forms.ToolStripMenuItem font2ToolStripMenuItem;
        private CzaryText.Control.DrawShape drawShape2;
        private System.Windows.Forms.ToolStripMenuItem loadSelectingSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWinSoundToolStripMenuItem;
        private CzaryText.Control.DrawShape drawShape3;
        private System.Windows.Forms.ToolStripMenuItem font3ToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxLasttimeSlowDown;
        private System.Windows.Forms.Button buttonSetSlownDown;
        private System.Windows.Forms.Label labelLastshowTime;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnNewSpin;
        private System.Windows.Forms.Button btnDelete;
    }
}


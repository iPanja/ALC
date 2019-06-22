namespace ALC {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.locateClientPicture = new System.Windows.Forms.PictureBox();
            this.initiateButton = new MetroFramework.Controls.MetroButton();
            this.outsidePanel = new System.Windows.Forms.Panel();
            this.insidePanel = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.monitorQueuePicture = new System.Windows.Forms.PictureBox();
            this.pbKeyTextbox = new MetroFramework.Controls.MetroTextBox();
            this.pbHelpButton = new MetroFramework.Controls.MetroButton();
            this.pbCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.disableCheckbox = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.locateClientPicture)).BeginInit();
            this.outsidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorQueuePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // locateClientPicture
            // 
            this.locateClientPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.locateClientPicture.Image = ((System.Drawing.Image)(resources.GetObject("locateClientPicture.Image")));
            this.locateClientPicture.Location = new System.Drawing.Point(103, 117);
            this.locateClientPicture.Name = "locateClientPicture";
            this.locateClientPicture.Size = new System.Drawing.Size(25, 23);
            this.locateClientPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.locateClientPicture.TabIndex = 1;
            this.locateClientPicture.TabStop = false;
            // 
            // initiateButton
            // 
            this.initiateButton.Location = new System.Drawing.Point(68, 80);
            this.initiateButton.Name = "initiateButton";
            this.initiateButton.Size = new System.Drawing.Size(320, 23);
            this.initiateButton.TabIndex = 2;
            this.initiateButton.Text = "Initiate";
            this.initiateButton.UseSelectable = true;
            this.initiateButton.Click += new System.EventHandler(this.initiateButton_Click);
            // 
            // outsidePanel
            // 
            this.outsidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outsidePanel.Controls.Add(this.insidePanel);
            this.outsidePanel.Location = new System.Drawing.Point(0, 362);
            this.outsidePanel.Name = "outsidePanel";
            this.outsidePanel.Size = new System.Drawing.Size(445, 10);
            this.outsidePanel.TabIndex = 3;
            // 
            // insidePanel
            // 
            this.insidePanel.BackColor = System.Drawing.Color.Cyan;
            this.insidePanel.Location = new System.Drawing.Point(0, 0);
            this.insidePanel.Name = "insidePanel";
            this.insidePanel.Size = new System.Drawing.Size(60, 10);
            this.insidePanel.TabIndex = 4;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(134, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Locate Client";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(135, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Monitor Queue";
            // 
            // monitorQueuePicture
            // 
            this.monitorQueuePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.monitorQueuePicture.Image = ((System.Drawing.Image)(resources.GetObject("monitorQueuePicture.Image")));
            this.monitorQueuePicture.Location = new System.Drawing.Point(103, 152);
            this.monitorQueuePicture.Name = "monitorQueuePicture";
            this.monitorQueuePicture.Size = new System.Drawing.Size(25, 23);
            this.monitorQueuePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.monitorQueuePicture.TabIndex = 6;
            this.monitorQueuePicture.TabStop = false;
            // 
            // pbKeyTextbox
            // 
            // 
            // 
            // 
            this.pbKeyTextbox.CustomButton.Image = null;
            this.pbKeyTextbox.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.pbKeyTextbox.CustomButton.Name = "";
            this.pbKeyTextbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pbKeyTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pbKeyTextbox.CustomButton.TabIndex = 1;
            this.pbKeyTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pbKeyTextbox.CustomButton.UseSelectable = true;
            this.pbKeyTextbox.CustomButton.Visible = false;
            this.pbKeyTextbox.Lines = new string[0];
            this.pbKeyTextbox.Location = new System.Drawing.Point(113, 305);
            this.pbKeyTextbox.MaxLength = 32767;
            this.pbKeyTextbox.Name = "pbKeyTextbox";
            this.pbKeyTextbox.PasswordChar = '\0';
            this.pbKeyTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pbKeyTextbox.SelectedText = "";
            this.pbKeyTextbox.SelectionLength = 0;
            this.pbKeyTextbox.SelectionStart = 0;
            this.pbKeyTextbox.ShortcutsEnabled = true;
            this.pbKeyTextbox.Size = new System.Drawing.Size(241, 23);
            this.pbKeyTextbox.TabIndex = 7;
            this.pbKeyTextbox.UseSelectable = true;
            this.pbKeyTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pbKeyTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pbKeyTextbox.TextChanged += new System.EventHandler(this.pbKeyTextbox_TextChanged);
            // 
            // pbHelpButton
            // 
            this.pbHelpButton.Location = new System.Drawing.Point(360, 304);
            this.pbHelpButton.Name = "pbHelpButton";
            this.pbHelpButton.Size = new System.Drawing.Size(28, 23);
            this.pbHelpButton.TabIndex = 8;
            this.pbHelpButton.Text = "?";
            this.pbHelpButton.UseSelectable = true;
            this.pbHelpButton.Click += new System.EventHandler(this.pbHelpButton_Click);
            // 
            // pbCheckbox
            // 
            this.pbCheckbox.AutoSize = true;
            this.pbCheckbox.Location = new System.Drawing.Point(81, 305);
            this.pbCheckbox.Name = "pbCheckbox";
            this.pbCheckbox.Size = new System.Drawing.Size(26, 15);
            this.pbCheckbox.TabIndex = 9;
            this.pbCheckbox.Text = " ";
            this.pbCheckbox.UseSelectable = true;
            this.pbCheckbox.CheckedChanged += new System.EventHandler(this.pbCheckbox_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(68, 283);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(156, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Pushbullet Notifications:";
            // 
            // disableCheckbox
            // 
            this.disableCheckbox.AutoSize = true;
            this.disableCheckbox.Location = new System.Drawing.Point(109, 190);
            this.disableCheckbox.Name = "disableCheckbox";
            this.disableCheckbox.Size = new System.Drawing.Size(130, 15);
            this.disableCheckbox.TabIndex = 11;
            this.disableCheckbox.Text = "Immediately Disable";
            this.disableCheckbox.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(445, 369);
            this.Controls.Add(this.disableCheckbox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.pbCheckbox);
            this.Controls.Add(this.pbHelpButton);
            this.Controls.Add(this.pbKeyTextbox);
            this.Controls.Add(this.monitorQueuePicture);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.outsidePanel);
            this.Controls.Add(this.initiateButton);
            this.Controls.Add(this.locateClientPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Auto League Client";
            ((System.ComponentModel.ISupportInitialize)(this.locateClientPicture)).EndInit();
            this.outsidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monitorQueuePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox locateClientPicture;
        private MetroFramework.Controls.MetroButton initiateButton;
        private System.Windows.Forms.Panel outsidePanel;
        private System.Windows.Forms.Panel insidePanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox monitorQueuePicture;
        private MetroFramework.Controls.MetroTextBox pbKeyTextbox;
        private MetroFramework.Controls.MetroButton pbHelpButton;
        private MetroFramework.Controls.MetroCheckBox pbCheckbox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox disableCheckbox;
    }
}


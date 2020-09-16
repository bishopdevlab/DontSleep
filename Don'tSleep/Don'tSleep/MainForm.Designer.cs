namespace Don_tSleep
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.checkBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.AllowScreenSaverAndSleep = new System.Windows.Forms.RadioButton();
            this.PreventSleep = new System.Windows.Forms.RadioButton();
            this.PreventScreenSaver = new System.Windows.Forms.RadioButton();
            this.PreventScreenSaverAndSleep = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxMoveMouse = new System.Windows.Forms.CheckBox();
            this.Copyright = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxAutoStart
            // 
            this.checkBoxAutoStart.AutoSize = true;
            this.checkBoxAutoStart.Checked = true;
            this.checkBoxAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoStart.Location = new System.Drawing.Point(260, 6);
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.Size = new System.Drawing.Size(78, 16);
            this.checkBoxAutoStart.TabIndex = 0;
            this.checkBoxAutoStart.Text = "Auto Start";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.CheckedChanged += new System.EventHandler(this.checkBoxAutoStart_CheckedChanged);
            // 
            // AllowScreenSaverAndSleep
            // 
            this.AllowScreenSaverAndSleep.AutoSize = true;
            this.AllowScreenSaverAndSleep.Location = new System.Drawing.Point(21, 98);
            this.AllowScreenSaverAndSleep.Name = "AllowScreenSaverAndSleep";
            this.AllowScreenSaverAndSleep.Size = new System.Drawing.Size(68, 16);
            this.AllowScreenSaverAndSleep.TabIndex = 1;
            this.AllowScreenSaverAndSleep.Text = "Unblock";
            this.AllowScreenSaverAndSleep.UseVisualStyleBackColor = true;
            this.AllowScreenSaverAndSleep.CheckedChanged += new System.EventHandler(this.PowerSaver_CheckedChanged);
            // 
            // PreventSleep
            // 
            this.PreventSleep.AutoSize = true;
            this.PreventSleep.Location = new System.Drawing.Point(21, 44);
            this.PreventSleep.Name = "PreventSleep";
            this.PreventSleep.Size = new System.Drawing.Size(185, 16);
            this.PreventSleep.TabIndex = 2;
            this.PreventSleep.Text = "Block Sleep/Hibernate mode";
            this.PreventSleep.UseVisualStyleBackColor = true;
            this.PreventSleep.CheckedChanged += new System.EventHandler(this.PowerSaver_CheckedChanged);
            // 
            // PreventScreenSaver
            // 
            this.PreventScreenSaver.AutoSize = true;
            this.PreventScreenSaver.Location = new System.Drawing.Point(21, 18);
            this.PreventScreenSaver.Name = "PreventScreenSaver";
            this.PreventScreenSaver.Size = new System.Drawing.Size(129, 16);
            this.PreventScreenSaver.TabIndex = 3;
            this.PreventScreenSaver.Text = "Block Screensaver";
            this.PreventScreenSaver.UseVisualStyleBackColor = true;
            this.PreventScreenSaver.CheckedChanged += new System.EventHandler(this.PowerSaver_CheckedChanged);
            // 
            // PreventScreenSaverAndSleep
            // 
            this.PreventScreenSaverAndSleep.AutoSize = true;
            this.PreventScreenSaverAndSleep.Checked = true;
            this.PreventScreenSaverAndSleep.Location = new System.Drawing.Point(21, 71);
            this.PreventScreenSaverAndSleep.Name = "PreventScreenSaverAndSleep";
            this.PreventScreenSaverAndSleep.Size = new System.Drawing.Size(285, 16);
            this.PreventScreenSaverAndSleep.TabIndex = 4;
            this.PreventScreenSaverAndSleep.TabStop = true;
            this.PreventScreenSaverAndSleep.Text = "Block Screensaver and Sleep/Hibernate mode";
            this.PreventScreenSaverAndSleep.UseVisualStyleBackColor = true;
            this.PreventScreenSaverAndSleep.CheckedChanged += new System.EventHandler(this.PowerSaver_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxMoveMouse);
            this.groupBox1.Controls.Add(this.PreventScreenSaver);
            this.groupBox1.Controls.Add(this.PreventScreenSaverAndSleep);
            this.groupBox1.Controls.Add(this.AllowScreenSaverAndSleep);
            this.groupBox1.Controls.Add(this.PreventSleep);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // checkBoxMoveMouse
            // 
            this.checkBoxMoveMouse.AutoSize = true;
            this.checkBoxMoveMouse.Location = new System.Drawing.Point(21, 130);
            this.checkBoxMoveMouse.Name = "checkBoxMoveMouse";
            this.checkBoxMoveMouse.Size = new System.Drawing.Size(178, 16);
            this.checkBoxMoveMouse.TabIndex = 6;
            this.checkBoxMoveMouse.Text = "Move Mouse Automatically";
            this.checkBoxMoveMouse.UseVisualStyleBackColor = true;
            this.checkBoxMoveMouse.CheckedChanged += new System.EventHandler(this.checkBoxMoveMouse_CheckedChanged);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(218, 185);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(120, 12);
            this.Copyright.TabIndex = 5;
            this.Copyright.Text = "Copyright by Bishop";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Don\'t Sleep is running!";
            this.notifyIcon.BalloonTipTitle = "Don\'t Sleep";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Don\'t Sleep";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ver. 1.2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxAutoStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Don\'t Sleep!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxAutoStart;
        private System.Windows.Forms.RadioButton AllowScreenSaverAndSleep;
        private System.Windows.Forms.RadioButton PreventSleep;
        private System.Windows.Forms.RadioButton PreventScreenSaver;
        private System.Windows.Forms.RadioButton PreventScreenSaverAndSleep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox checkBoxMoveMouse;
        private System.Windows.Forms.Label label1;
    }
}


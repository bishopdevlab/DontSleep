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
            resources.ApplyResources(this.checkBoxAutoStart, "checkBoxAutoStart");
            this.checkBoxAutoStart.Checked = true;
            this.checkBoxAutoStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoStart.Name = "checkBoxAutoStart";
            this.checkBoxAutoStart.UseVisualStyleBackColor = true;
            this.checkBoxAutoStart.CheckedChanged += new System.EventHandler(this.checkBoxAutoStart_CheckedChanged);
            // 
            // AllowScreenSaverAndSleep
            // 
            resources.ApplyResources(this.AllowScreenSaverAndSleep, "AllowScreenSaverAndSleep");
            this.AllowScreenSaverAndSleep.Name = "AllowScreenSaverAndSleep";
            this.AllowScreenSaverAndSleep.UseVisualStyleBackColor = true;
            this.AllowScreenSaverAndSleep.CheckedChanged += new System.EventHandler(this.PowerSaver_CheckedChanged);
            // 
            // PreventSleep
            // 
            resources.ApplyResources(this.PreventSleep, "PreventSleep");
            this.PreventSleep.Name = "PreventSleep";
            this.PreventSleep.UseVisualStyleBackColor = true;
            this.PreventSleep.CheckedChanged += new System.EventHandler(this.PowerSaver_CheckedChanged);
            // 
            // PreventScreenSaver
            // 
            resources.ApplyResources(this.PreventScreenSaver, "PreventScreenSaver");
            this.PreventScreenSaver.Name = "PreventScreenSaver";
            this.PreventScreenSaver.UseVisualStyleBackColor = true;
            this.PreventScreenSaver.CheckedChanged += new System.EventHandler(this.PowerSaver_CheckedChanged);
            // 
            // PreventScreenSaverAndSleep
            // 
            resources.ApplyResources(this.PreventScreenSaverAndSleep, "PreventScreenSaverAndSleep");
            this.PreventScreenSaverAndSleep.Checked = true;
            this.PreventScreenSaverAndSleep.Name = "PreventScreenSaverAndSleep";
            this.PreventScreenSaverAndSleep.TabStop = true;
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBoxMoveMouse
            // 
            resources.ApplyResources(this.checkBoxMoveMouse, "checkBoxMoveMouse");
            this.checkBoxMoveMouse.Name = "checkBoxMoveMouse";
            this.checkBoxMoveMouse.UseVisualStyleBackColor = true;
            this.checkBoxMoveMouse.CheckedChanged += new System.EventHandler(this.checkBoxMoveMouse_CheckedChanged);
            // 
            // Copyright
            // 
            resources.ApplyResources(this.Copyright, "Copyright");
            this.Copyright.Name = "Copyright";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBoxAutoStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
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


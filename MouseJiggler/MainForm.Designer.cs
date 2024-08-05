
namespace ArkaneSystems.MouseJiggler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            jiggleTimer = new System.Windows.Forms.Timer(components);
            flpLayout = new System.Windows.Forms.FlowLayoutPanel();
            panelBase = new System.Windows.Forms.Panel();
            cmdAbout = new System.Windows.Forms.Button();
            cmdTrayify = new System.Windows.Forms.Button();
            cbSettings = new System.Windows.Forms.CheckBox();
            cbJiggling = new System.Windows.Forms.CheckBox();
            panelSettings = new System.Windows.Forms.Panel();
            dTimer = new System.Windows.Forms.DateTimePicker();
            cbTimeEnd = new System.Windows.Forms.CheckBox();
            lbPeriod = new System.Windows.Forms.Label();
            tbPeriod = new System.Windows.Forms.TrackBar();
            cbMinimize = new System.Windows.Forms.CheckBox();
            cbZen = new System.Windows.Forms.CheckBox();
            niTray = new System.Windows.Forms.NotifyIcon(components);
            stopTimer = new System.Windows.Forms.Timer(components);
            flpLayout.SuspendLayout();
            panelBase.SuspendLayout();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).BeginInit();
            SuspendLayout();
            // 
            // jiggleTimer
            // 
            jiggleTimer.Interval = 1000;
            jiggleTimer.Tick += jiggleTimer_Tick;
            // 
            // flpLayout
            // 
            flpLayout.AutoSize = true;
            flpLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpLayout.Controls.Add(panelBase);
            flpLayout.Controls.Add(panelSettings);
            flpLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpLayout.Location = new System.Drawing.Point(0, 0);
            flpLayout.Name = "flpLayout";
            flpLayout.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            flpLayout.Size = new System.Drawing.Size(305, 190);
            flpLayout.TabIndex = 2;
            // 
            // panelBase
            // 
            panelBase.Controls.Add(cmdAbout);
            panelBase.Controls.Add(cmdTrayify);
            panelBase.Controls.Add(cbSettings);
            panelBase.Controls.Add(cbJiggling);
            panelBase.Location = new System.Drawing.Point(8, 9);
            panelBase.Name = "panelBase";
            panelBase.Size = new System.Drawing.Size(289, 32);
            panelBase.TabIndex = 3;
            // 
            // cmdAbout
            // 
            cmdAbout.Location = new System.Drawing.Point(198, 2);
            cmdAbout.Name = "cmdAbout";
            cmdAbout.Size = new System.Drawing.Size(40, 26);
            cmdAbout.TabIndex = 2;
            cmdAbout.Text = "?";
            cmdAbout.UseVisualStyleBackColor = true;
            cmdAbout.Click += cmdAbout_Click;
            // 
            // cmdTrayify
            // 
            cmdTrayify.Location = new System.Drawing.Point(244, 2);
            cmdTrayify.Name = "cmdTrayify";
            cmdTrayify.Size = new System.Drawing.Size(40, 26);
            cmdTrayify.TabIndex = 3;
            cmdTrayify.Text = "🔽";
            cmdTrayify.UseVisualStyleBackColor = true;
            cmdTrayify.Click += cmdTrayify_Click;
            // 
            // cbSettings
            // 
            cbSettings.Location = new System.Drawing.Point(88, 6);
            cbSettings.Name = "cbSettings";
            cbSettings.Size = new System.Drawing.Size(77, 22);
            cbSettings.TabIndex = 1;
            cbSettings.Text = "设置...";
            cbSettings.UseVisualStyleBackColor = true;
            cbSettings.CheckedChanged += cbSettings_CheckedChanged;
            // 
            // cbJiggling
            // 
            cbJiggling.AutoSize = true;
            cbJiggling.Location = new System.Drawing.Point(10, 6);
            cbJiggling.Name = "cbJiggling";
            cbJiggling.Size = new System.Drawing.Size(75, 21);
            cbJiggling.TabIndex = 0;
            cbJiggling.Text = "晃动鼠标";
            cbJiggling.UseVisualStyleBackColor = true;
            cbJiggling.CheckedChanged += cbJiggling_CheckedChanged;
            // 
            // panelSettings
            // 
            panelSettings.AutoSize = true;
            panelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelSettings.Controls.Add(dTimer);
            panelSettings.Controls.Add(cbTimeEnd);
            panelSettings.Controls.Add(lbPeriod);
            panelSettings.Controls.Add(tbPeriod);
            panelSettings.Controls.Add(cbMinimize);
            panelSettings.Controls.Add(cbZen);
            panelSettings.Location = new System.Drawing.Point(8, 47);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new System.Drawing.Size(289, 134);
            panelSettings.TabIndex = 2;
            panelSettings.Visible = false;
            // 
            // dTimer
            // 
            dTimer.CustomFormat = "HH:MM";
            dTimer.Enabled = false;
            dTimer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dTimer.Location = new System.Drawing.Point(100, 106);
            dTimer.Name = "dTimer";
            dTimer.ShowUpDown = true;
            dTimer.Size = new System.Drawing.Size(114, 23);
            dTimer.TabIndex = 10;
            // 
            // cbTimeEnd
            // 
            cbTimeEnd.AutoSize = true;
            cbTimeEnd.Location = new System.Drawing.Point(10, 110);
            cbTimeEnd.Name = "cbTimeEnd";
            cbTimeEnd.Size = new System.Drawing.Size(78, 21);
            cbTimeEnd.TabIndex = 9;
            cbTimeEnd.Text = "停止晃动:";
            cbTimeEnd.UseVisualStyleBackColor = true;
            cbTimeEnd.CheckedChanged += cbTimeEnd_CheckedChanged;
            // 
            // lbPeriod
            // 
            lbPeriod.AutoSize = true;
            lbPeriod.Location = new System.Drawing.Point(244, 46);
            lbPeriod.Name = "lbPeriod";
            lbPeriod.Size = new System.Drawing.Size(31, 17);
            lbPeriod.TabIndex = 3;
            lbPeriod.Text = "1 秒";
            // 
            // tbPeriod
            // 
            tbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbPeriod.Location = new System.Drawing.Point(4, 70);
            tbPeriod.Maximum = 60;
            tbPeriod.Minimum = 1;
            tbPeriod.Name = "tbPeriod";
            tbPeriod.Size = new System.Drawing.Size(281, 45);
            tbPeriod.TabIndex = 6;
            tbPeriod.TickFrequency = 2;
            tbPeriod.Value = 1;
            tbPeriod.ValueChanged += tbPeriod_ValueChanged;
            // 
            // cbMinimize
            // 
            cbMinimize.AutoSize = true;
            cbMinimize.Location = new System.Drawing.Point(10, 42);
            cbMinimize.Name = "cbMinimize";
            cbMinimize.Size = new System.Drawing.Size(119, 21);
            cbMinimize.TabIndex = 5;
            cbMinimize.Text = "启动时最小化(&M)";
            cbMinimize.UseVisualStyleBackColor = true;
            cbMinimize.CheckedChanged += cbMinimize_CheckedChanged;
            // 
            // cbZen
            // 
            cbZen.AutoSize = true;
            cbZen.Location = new System.Drawing.Point(10, 12);
            cbZen.Name = "cbZen";
            cbZen.Size = new System.Drawing.Size(165, 21);
            cbZen.TabIndex = 4;
            cbZen.Text = "禅动模式:看不到鼠标动(&Z)";
            cbZen.UseVisualStyleBackColor = true;
            cbZen.CheckedChanged += cbZen_CheckedChanged;
            // 
            // niTray
            // 
            niTray.Icon = (System.Drawing.Icon)resources.GetObject("niTray.Icon");
            niTray.Text = "Mouse Jiggler";
            niTray.DoubleClick += niTray_DoubleClick;
            // 
            // stopTimer
            // 
            stopTimer.Interval = 1000;
            stopTimer.Tick += stopTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(304, 190);
            Controls.Add(flpLayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Mouse Jiggler 中文增强版";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            flpLayout.ResumeLayout(false);
            flpLayout.PerformLayout();
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer jiggleTimer;
        private System.Windows.Forms.FlowLayoutPanel flpLayout;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TrackBar tbPeriod;
        private System.Windows.Forms.CheckBox cbMinimize;
        private System.Windows.Forms.CheckBox cbZen;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.CheckBox cbSettings;
        private System.Windows.Forms.CheckBox cbJiggling;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.Button cmdTrayify;
        private System.Windows.Forms.CheckBox cbTimeEnd;
        private System.Windows.Forms.DateTimePicker dTimer;
        private System.Windows.Forms.Timer stopTimer;
    }
}


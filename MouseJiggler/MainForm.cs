#region header

// MouseJiggler - MainForm.cs
// 
// Created by: Alistair J R Young (avatar) at 2021/01/24 1:57 AM.

#endregion

#region using

using System;
using System.Diagnostics;
using System.Windows.Forms;

using ArkaneSystems.MouseJiggler.Properties;

#endregion

namespace ArkaneSystems.MouseJiggler
{
    public partial class MainForm : Form
    {
        /// <summary>
        ///     Constructor for use by the form designer.
        /// </summary>
        public MainForm()
            : this(jiggleOnStartup: false, minimizeOnStartup: false, zenJiggleEnabled: false, jigglePeriod: 1)
        { }

        public MainForm(bool jiggleOnStartup, bool minimizeOnStartup, bool zenJiggleEnabled, int jigglePeriod)
        {
            this.InitializeComponent();

            // Jiggling on startup?
            this.JiggleOnStartup = jiggleOnStartup;

            // Set settings properties
            // We do this by setting the controls, and letting them set the properties.

            this.cbMinimize.Checked = minimizeOnStartup;
            this.cbZen.Checked = zenJiggleEnabled;
            this.tbPeriod.Value = jigglePeriod;
        }

        public bool JiggleOnStartup { get; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.JiggleOnStartup)
                this.cbJiggling.Checked = true;
        }

        private void UpdateNotificationAreaText()
        {
            if (!this.cbJiggling.Checked)
            {
                this.niTray.Text = "未晃动鼠标.";
            }
            else
            {
                string? ww = this.ZenJiggleEnabled ? "采用" : "未采用";
                this.niTray.Text = $"每 {this.JigglePeriod} 秒晃动鼠标, {ww} 禅动模式.";

                if (cbTimeEnd.Checked)
                {
                    string atTime = dTimer.Value.ToString("HH:mm:ss");
                    this.niTray.Text += $" 结束时间:{atTime}";
                }
            }
        }

        private void cmdAbout_Click(object sender, EventArgs e)
        {
            string txt = "MouseJiggler 是一个开源的鼠标晃动工具，它可以让你在任何时候、任何地点、任何情况下都能轻松地晃动你的鼠标。";
            txt += "\r\n\r\n\t原作者: Alistair J. R. Young 2007-2021";
            txt += "\r\n\t小恐龙工作室 xkonglong.com汉化修改";
            MessageBox.Show(txt, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Property synchronization

        private void cbSettings_CheckedChanged(object sender, EventArgs e)
        {
            this.panelSettings.Visible = this.cbSettings.Checked;
        }

        private void cbMinimize_CheckedChanged(object sender, EventArgs e)
        {
            this.MinimizeOnStartup = this.cbMinimize.Checked;
        }

        private void cbZen_CheckedChanged(object sender, EventArgs e)
        {
            this.ZenJiggleEnabled = this.cbZen.Checked;
        }

        private void tbPeriod_ValueChanged(object sender, EventArgs e)
        {
            this.JigglePeriod = this.tbPeriod.Value;
        }

        #endregion Property synchronization

        #region Do the Jiggle!

        protected bool Zig = true;

        private void cbJiggling_CheckedChanged(object sender, EventArgs e)
        {
            this.jiggleTimer.Enabled = this.cbJiggling.Checked;
        }

        private void jiggleTimer_Tick(object sender, EventArgs e)
        {
            if (this.ZenJiggleEnabled)
                Helpers.Jiggle(delta: 0);
            else if (this.Zig)
                Helpers.Jiggle(delta: 4);
            else //zag
                Helpers.Jiggle(delta: -4);

            this.Zig = !this.Zig;
        }

        #endregion Do the Jiggle!

        #region Minimize and restore

        private void cmdTrayify_Click(object sender, EventArgs e)
        {
            this.MinimizeToTray();
        }

        private void niTray_DoubleClick(object sender, EventArgs e)
        {
            this.RestoreFromTray();
        }

        private void MinimizeToTray()
        {
            this.Visible = false;
            this.ShowInTaskbar = false;
            this.niTray.Visible = true;

            this.UpdateNotificationAreaText();
        }

        private void RestoreFromTray()
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.niTray.Visible = false;
        }

        #endregion Minimize and restore

        #region Settings property backing fields

        private int jigglePeriod;

        private bool minimizeOnStartup;

        private bool zenJiggleEnabled;

        #endregion Settings property backing fields

        #region Settings properties

        public bool MinimizeOnStartup
        {
            get => this.minimizeOnStartup;
            set
            {
                this.minimizeOnStartup = value;
                Settings.Default.MinimizeOnStartup = value;
                Settings.Default.Save();
            }
        }

        public bool ZenJiggleEnabled
        {
            get => this.zenJiggleEnabled;
            set
            {
                this.zenJiggleEnabled = value;
                Settings.Default.ZenJiggle = value;
                Settings.Default.Save();
            }
        }

        public int JigglePeriod
        {
            get => this.jigglePeriod;
            set
            {
                this.jigglePeriod = value;
                Settings.Default.JigglePeriod = value;
                Settings.Default.Save();

                this.jiggleTimer.Interval = value * 1000;
                this.lbPeriod.Text = $"{value} 秒";
            }
        }

        #endregion Settings properties

        #region Minimize on start

        private bool firstShown = true;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (this.firstShown && this.MinimizeOnStartup)
                this.MinimizeToTray();

            this.firstShown = false;
        }

        #endregion

        private void cbTimeEnd_CheckedChanged(object sender, EventArgs e)
        {
            dTimer.Enabled = cbTimeEnd.Checked;
            stopTimer.Enabled = cbTimeEnd.Checked;
            if (dTimer.Enabled)
            {
                if (dTimer.Value < DateTime.Now)
                    dTimer.Value = DateTime.Now.AddMinutes(5);
                
            }
        }

        private void stopTimer_Tick(object sender, EventArgs e)
        {
            if(DateTime.Now >= dTimer.Value)
            {
                cbJiggling.Checked = false;
                jiggleTimer.Enabled = false;
                cbTimeEnd.Checked = false;
                dTimer.Enabled = false;
            }
            Debug.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}

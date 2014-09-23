using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ShinyAddFirewallRule
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var list = Process.GetProcesses().Select(process => new ProcessItem(process)).ToList();
            list.Sort((a, b) => a.ToString().CompareTo(b.ToString()));

            uiProgram.Items.Clear();
            foreach (var item in list)
                uiProgram.Items.Add(item);
        }

        private void uiProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiProgram.SelectedItem == null)
                return;
            //if (uiName.ReadOnly)
            {
                uiName.Text = "_Program: " + (uiProgram.SelectedItem as ProcessItem).Process.ProcessName;
                uiName.ReadOnly = false;
                uiButtonRun.Enabled = true;
            }
        }

        private void uiButtonRun_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo("netsh.exe", "advfirewall firewall add rule name=\"" + uiName.Text + "\" dir=out action=allow program=\"" + (uiProgram.SelectedItem as ProcessItem).Process.MainModule.FileName + "\" enable=yes");
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            //MessageBox.Show(startInfo.Arguments, startInfo.FileName);
            var p = Process.Start(startInfo);
            p.WaitForExit();
            var stdOut = p.StandardOutput.ReadToEnd();
            var stdErr = p.StandardError.ReadToEnd();
            if ((stdOut.Trim() != "Ok.") || !string.IsNullOrEmpty(stdErr))
                MessageBox.Show("stdout: " + stdOut + "\nstderr: " + stdErr);
        }
    }
}

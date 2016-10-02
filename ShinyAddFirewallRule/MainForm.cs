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
            LoadProcessList();
        }

        private void LoadProcessList()
        {
            var list = Process.GetProcesses().Select(process => new ProcessItem(process)).ToList();
            list.Sort((a, b) => string.Compare(a.ToString(), b.ToString(), StringComparison.Ordinal));

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
                uiName.Text = "_Program: " + (uiProgram.SelectedItem as ProcessItem).ProcessName;
                uiName.ReadOnly = false;
                uiButtonRun.Enabled = true;
            }
        }

        private void uiButtonRun_Click(object sender, EventArgs e)
        {
            Program.AddFirewallRule((uiProgram.SelectedItem as ProcessItem).FileName, uiName.Text);
        }
    }
}

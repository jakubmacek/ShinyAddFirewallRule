using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyAddFirewallRule
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                foreach (var fileName in args)
                    AddFirewallRule(fileName, "_Program: " + fileName);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        internal static void AddFirewallRule(string fileName, string name)
        {
            var startInfo = new ProcessStartInfo("netsh.exe", "advfirewall firewall add rule name=\"" + name + "\" dir=out action=allow program=\"" + fileName + "\" enable=yes");
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

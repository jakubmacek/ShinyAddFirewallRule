using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ShinyAddFirewallRule
{
    class ProcessItem
    {
        public string FileName { get; private set; }
        public string ProcessName { get; private set; }

        public ProcessItem(Process process)
        {
            try
            {
                ProcessName = process.ProcessName;
                FileName = process.MainModule.FileName;
            }
            catch
            {
                ProcessName = "-- access denied -- ";
                FileName = "-- access denied -- ";
            }
        }

        public override string ToString()
        {
            return FileName;
        }
    }
}

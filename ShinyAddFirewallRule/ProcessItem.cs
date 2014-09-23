using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ShinyAddFirewallRule
{
    class ProcessItem
    {
        public Process Process { get; private set; }

        public ProcessItem(Process process)
        {
            Process = process;
        }

        public override string ToString()
        {
            try
            {
                return Process.MainModule.FileName;
            }
            catch
            {
                return "-- access denied -- ";
            }
        }
    }
}

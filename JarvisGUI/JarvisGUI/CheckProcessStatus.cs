using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarvisGUI
{
    class CheckProcessStatus
    {
        public bool pStatus(string process) {
           
            if (Process.GetProcessesByName(process).Length>0)
            {
                return true;
            }
            return false;
        }
    }
}

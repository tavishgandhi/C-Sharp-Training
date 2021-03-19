using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A1Q2
{
    public class WorkPerformedEventArgs: EventArgs
    {
        public WorkPerformedEventArgs(int hours, string type)
        {
            this.hours = hours;
            this.WorkType = type;
        }
        public int  hours { get; set; }
        public string WorkType { get; set; }
    }

}

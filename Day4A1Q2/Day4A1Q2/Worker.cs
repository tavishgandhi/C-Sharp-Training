using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A1Q2
{
    
    class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, string h)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i + 1, h);
            }
            OnWorkCompleted();
        }

        protected virtual void OnWorkPerformed(int hours, string h)
        {
            if (WorkPerformed is not null)
                WorkPerformed(this, new WorkPerformedEventArgs(hours, h));
        }
        protected virtual void OnWorkCompleted()
        {
            if (WorkCompleted is not null)
                WorkCompleted(this, EventArgs.Empty);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetDNS
{
    public static class TaskEx
    {
        public static Task Run(Action thread)
        {
            return Task.Factory.StartNew(thread);
        }

        public static Task Run(Action thread, Action completed, bool completedInFormThread = true)
        {
            TaskScheduler taskScheduler;

            if (completedInFormThread)
            {
                taskScheduler = TaskScheduler.FromCurrentSynchronizationContext();
            }
            else
            {
                taskScheduler = TaskScheduler.Current;
            }

            return Run(thread).ContinueWith(task => completed(), taskScheduler);
        }
    }
}

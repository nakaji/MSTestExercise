using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExercise
{
    public class BackgroundTask
    {
        public BackgroundTask(Runnable runnable)
        {
            
        }
    }

    public class Runnable
    {
        public Task Run { get; private set; }

        public Runnable(Task task)
        {
            Run = task;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExercise
{
    public class BackgroundTask
    {
        private readonly Runnable _runnable;

        public BackgroundTask(Runnable runnable)
        {
            _runnable = runnable;
        }

        public void Invoke()
        {
            _runnable.Run.Start();
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

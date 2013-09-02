using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTestExercise
{
    public class Counter
    {
        private int counter = 0;

        public object Increment()
        {
            return ++counter;
        }
    }
}

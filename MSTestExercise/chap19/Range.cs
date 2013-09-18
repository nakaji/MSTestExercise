using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MSTestExercise.chap19
{
    public class Range
    {
        public double Min { get; private set; }
        public double Max { get; private set; }

        public Range(double min, double max)
        {
            Min = min;
            Max = max;
        }

        public bool Contains(double p)
        {
            return p >= Min && p <= Max;
        }
    }
}

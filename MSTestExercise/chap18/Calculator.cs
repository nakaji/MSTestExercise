using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExercise
{
    public static class Calculator
    {
        public static int Divide(int x, int y)
        {
            if (y == 0) throw new ArgumentOutOfRangeException();

            return x / y;
        }
    }
}

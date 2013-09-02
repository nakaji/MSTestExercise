using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExercise.chap19
{
    public class FizzBuzz
    {
        public static List<String> CreateFizzBuzzList(int num)
        {
            return Enumerable.Range(1, num).Select(i => i.ToString()).ToList();
        }
    }
}

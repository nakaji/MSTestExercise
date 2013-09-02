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
            return Enumerable.Range(1, num).Select(i => i % 15 == 0 ? "FizzBuzz" : i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString()).ToList();
        }
    }
}

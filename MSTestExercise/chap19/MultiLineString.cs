using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTestExercise.chap19
{
    public static class MultiLineString
    {
        public static string Join(params string[] args)
        {
            var result = args.First();
            foreach (var str in args.Skip(1))
            {
                result += "\n" + str;
            }
            return result;
        }
    }
}

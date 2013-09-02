using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSTestExercise
{
    public static class StringUtil
    {
        public static object ToSnakeCase(string p)
        {
            var buf = p;

            foreach (var i in Enumerable.Range('A', 'Z' - 'A'))
            {
                var old = ((char)i).ToString();
                buf = buf.Replace(old, "_" + old);
            }

            return Regex.Replace(buf, "^_", "").ToLower();
        }
    }
}

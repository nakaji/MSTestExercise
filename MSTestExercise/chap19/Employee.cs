using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MSTestExercise.chap19
{
    public class Employee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }

        public Employee(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public static List<Employee> Load(string fileName)
        {
            if (!File.Exists(fileName)) throw new FileNotFoundException();

            var list = new List<Employee>();
            var data = File.ReadAllLines(fileName);
            data.ToList().ForEach(x =>
                                  {
                                      var col = x.Split(',');
                                      list.Add(new Employee(col[0], col[1], col[2]));
                                  });



            return list;
        }
    }
}

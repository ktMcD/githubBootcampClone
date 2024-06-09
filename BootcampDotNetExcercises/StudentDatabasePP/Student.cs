using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabasePP
{
    public class Student
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public Favorites Favorites { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }
}

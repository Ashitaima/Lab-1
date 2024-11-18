using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_1.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int groupNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}


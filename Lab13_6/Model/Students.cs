using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_6.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }


        public Student(string firstName, string lastName, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ";
        }
    }
}


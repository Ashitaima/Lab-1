using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_5.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public Student(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ";
        }
    }
}


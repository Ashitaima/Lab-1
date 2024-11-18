using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_8.Model
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Grades { get; set; }


        public Student(string firstName, string lastName, List<int> grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grades = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} ";
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_9.Model
{
    public class Student
    {
        public string FacultyNumber { get; set; }
        public List<int> Grades { get; set; }

        public Student(string facultyNumber, List<int> grades) 
        {
            FacultyNumber = facultyNumber;
            Grades = grades;
        }
        public override string ToString()
        {
            return string.Join(" ", Grades);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_11.Model
{
    public class StudentSpecialty
    {
        public string SpecialtyName { get; set; }
        public int FacultyNumber { get; set; }

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            SpecialtyName = specialtyName;
            FacultyNumber = facultyNumber;
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int FacultyNumber { get; set; }

        public Student(string name, string surname, int facultyNumber)
        {
            Name = name;
            Surname = surname;
            FacultyNumber = facultyNumber;
        }
    }
}


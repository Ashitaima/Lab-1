using Lab13_11.Model;

namespace Lab13_11
{
    internal class Program
    {
        static void Main()
        {
            List<StudentSpecialty> specialties = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();

            string input;
            while ((input = Console.ReadLine()) != "Students:")
            {
                string[] parts = input.Split();
                string specialtyName = string.Join(" ", parts.Take(parts.Length - 1));
                int facultyNumber = int.Parse(parts.Last());

                specialties.Add(new StudentSpecialty(specialtyName, facultyNumber));
            }

            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split();
                int facultyNumber = int.Parse(parts[0]);
                string name = parts[1];
                string surname = parts[2];

                students.Add(new Student(name, surname, facultyNumber));
            }

            var joinedData = from student in students
                             join specialty in specialties on student.FacultyNumber equals specialty.FacultyNumber
                             orderby student.Name
                             select new
                             {
                                 student.Name,
                                 student.Surname,
                                 student.FacultyNumber,
                                 specialty.SpecialtyName
                             };

            foreach (var item in joinedData)
            {
                Console.WriteLine($"{item.Surname} {item.Name} {item.FacultyNumber} {item.SpecialtyName}");
            }
        }
    }
}

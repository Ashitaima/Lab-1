using Lab13_9.Model;
namespace Lab13_9
{
    internal class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var parts = input.Split(' ');
                string facultyNumber = parts[0];
                List<int> grades = parts.Skip(1).Select(int.Parse).ToList();
                students.Add(new Student(facultyNumber, grades));
            }

            var result = students
            .Where(s => (s.FacultyNumber.Substring(4, 2) == "14" || s.FacultyNumber.Substring(4, 2) == "15"));

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}

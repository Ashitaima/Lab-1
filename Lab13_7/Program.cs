using Lab13_7.Model;
namespace Lab13_7
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
                string firstName = parts[0];
                string lastName = parts[1];
                List<int> grades = parts.Skip(2).Select(int.Parse).ToList();
                students.Add(new Student(firstName, lastName, grades));
            }

            var result = students
                .Where(s => s.Grades.Contains(6));

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}

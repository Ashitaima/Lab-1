using Lab13_4.Model;
namespace Lab13_4
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
                students.Add(new Student(firstName, lastName));
            }

            var result = students
                .OrderBy(s => s.LastName)
                .ThenByDescending(s => s.FirstName);

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}

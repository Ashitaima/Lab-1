using Lab13_2.Model;
namespace Lab13_2
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
                .Where(s => string.Compare(s.FirstName, s.LastName, StringComparison.Ordinal) < 0);

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}

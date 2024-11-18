using Lab13_6.Model;
namespace Lab13_6
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
                string phone = parts[2];
                students.Add(new Student(firstName, lastName, phone));
            }

            var result = students
             .Where(s => s.Phone.StartsWith("02") || s.Phone.StartsWith("+3592"));

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}

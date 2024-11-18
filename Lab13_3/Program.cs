using Lab13_3.Model;

namespace Lab13_3
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
                int age = int.Parse(parts[2]);
                students.Add(new Student(firstName, lastName, age));            
            }

            var result = students
                .Where(s => s.Age >= 18 && s.Age <= 24);

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }
    }
}

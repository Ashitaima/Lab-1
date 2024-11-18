using Lab13_10.Model;
namespace Lab13_10
{
    internal class Program
    {
        static void Main()
        {
            List<Person> students = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] parts = input.Split();
                string name = parts[0] + " " + parts[1];
                int group = int.Parse(parts[2]);

                students.Add(new Person(name, group));
            }

            var groupedStudents = students
                .GroupBy(s => s.Group)
                .OrderBy(g => g.Key); 

            foreach (var group in groupedStudents)
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ", group.Select(s => s.Name))}");
            }
        }
    }
}

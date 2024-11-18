using Lab13_1.Model;

namespace Lab13_1
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
                int groupNumber = int.Parse(parts[2]);
                students.Add(new Student(firstName, lastName, groupNumber));
                
            }
            var result = students
           .Where(s => s.GroupNumber == 2)
           .OrderBy(s => s.FirstName);

            foreach (var student in result)
            {
                Console.WriteLine(student);
            }
        }

    }
}

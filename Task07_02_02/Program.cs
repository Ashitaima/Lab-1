using Task07_02_01.Model;

namespace Task07_02_02
{
    internal class Program
    {
        static void Main()
        {
            List<IBirth> birthables = new List<IBirth>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parts = input.Split();
                if (parts[0] == "Citizen") 
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birthDate = parts[4];
                    birthables.Add(new Citizen(name, age, id, birthDate));
                }
                else if (parts[0] == "Pet") 
                {
                    string name = parts[1];
                    string birthDate = parts[2];
                    birthables.Add(new Pet(name, birthDate));
                }
            }

            string year = Console.ReadLine();

            foreach (var birthable in birthables)
            {
                if (birthable.BirthDate.EndsWith(year))
                {
                    Console.WriteLine(birthable.BirthDate);
                }
            }
        }
    }
}

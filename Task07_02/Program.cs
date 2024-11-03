using Task07_02_01.Model;

namespace Task07_02
{
    internal class Program
    {
        static void Main()
        {
            List<IIdentifiable> entities = new List<IIdentifiable>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] parts = input.Split();
                if (parts.Length == 3) 
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    entities.Add(new Citizen(name, age, id));
                }
                else if (parts.Length == 2) 
                {
                    string model = parts[0];
                    string id = parts[1];
                    entities.Add(new Robot(model, id));
                }
            }

            string fakeIdEnding = Console.ReadLine();

            foreach (var c in entities)
            {
                if (c.Id.EndsWith(fakeIdEnding))
                {
                    Console.WriteLine(c.Id);
                }
            }
        }
    }
}

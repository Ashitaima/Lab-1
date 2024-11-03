using Task07_02_01.Model;

namespace Task07_02_03
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                if (parts.Length == 4) 
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string id = parts[2];
                    string birthDate = parts[3];
                    buyers[name] = new Citizen(name, age, id, birthDate);
                }
                else if (parts.Length == 3) 
                {
                    string name = parts[0];
                    int age = int.Parse(parts[1]);
                    string group = parts[2];
                    buyers[name] = new Rebel(name, age, group);
                }
            }

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                if (buyers.ContainsKey(input))
                {
                    buyers[input].BuyFood();
                }
            }

            int totalFood = 0;
            foreach (var b in buyers.Values)
            {
                totalFood += b.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}

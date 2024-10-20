namespace Task05_01
{
    using System;
    using Task05_01.Model;
    class Program
    {
        static void Main()
        {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("The name cannot be empty or contains space");
                return;
            }
            if (age < Chicken.MinAge || age > Chicken.MaxAge) 
            {
                Console.WriteLine("Age should be between 0 and 15.");
                return;
            }

            Chicken chicken = new Chicken(name, age);
            Console.WriteLine(
                    "Chicken {0} (age {1}) can produce {2} eggs per day.",
                    chicken.Name,
                    chicken.Age,
                    chicken.ProductPerDay); 
        }
    }
}
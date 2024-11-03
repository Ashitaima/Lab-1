using System;
using Task05_03.Models;

namespace Task05_03
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                string[] pizzaName = Console.ReadLine().Split(' ');
                Pizza pizza = new Pizza(pizzaName[1]);
                //Тісто
                string[] doughInput = Console.ReadLine().Split(' ');
                Dough dough = new Dough (doughInput[1], doughInput[2], double.Parse(doughInput[3]));
                pizza.Dough = dough;


                //Допінги
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] toppingDetails = command.Split();
                    string toppingType = toppingDetails[1];
                    double weightTop = double.Parse(toppingDetails[2]);
                    Topping topping = new Topping(toppingType, weightTop);
                    pizza.AddTopping(topping);
                }
                Console.WriteLine(pizza);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
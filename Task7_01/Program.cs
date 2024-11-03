using System;
using System.Linq;

namespace Task7_01
{
    using Task7_01.Model;
    class Program
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone smartphone = new Smartphone();

            foreach (var number in numbers)
            {
                smartphone.Call(number);
            }

            foreach (var url in urls)
            {
                smartphone.Browse(url);
            }
        }
    }
}

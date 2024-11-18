using System;
using Task09_08.Model;

namespace Task09_08
{
    class Program
    {
        static void Main()
        {
            Box<string> box = new Box<string>();
            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandArgs = command.Split();

                switch (commandArgs[0])
                {
                    case "Add":
                        box.Add(commandArgs[1]);
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(commandArgs[1]);
                        box.Remove(removeIndex);
                        break;
                    case "Contains":
                        string containsElement = commandArgs[1];
                        Console.WriteLine(box.Contains(containsElement));
                        break;
                    case "Swap":
                        int index1 = int.Parse(commandArgs[1]);
                        int index2 = int.Parse(commandArgs[2]);
                        box.Swap(index1, index2);
                        break;
                    case "Greater":
                        string greaterElement = commandArgs[1];
                        Console.WriteLine(box.CountGreaterThan(greaterElement));
                        break;
                    case "Max":
                        Console.WriteLine(box.Max());
                        break;
                    case "Min":
                        Console.WriteLine(box.Min());
                        break;
                    case "Print":
                        box.Print();
                        break;
                    case "Sort":
                        Sorter.Sort(box);
                        break;
                }
            }
        }
    }
}

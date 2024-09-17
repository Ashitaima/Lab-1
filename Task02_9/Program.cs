using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть букви (без пробілів):");
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        string input = Console.ReadLine();

        foreach (char c in input)
        {
            int index = Array.IndexOf(alphabet, c);
            Console.WriteLine($"{c} -> {index}");
        }
    }
}

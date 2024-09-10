using System;

class Program
{
    static void Main()
    {
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        string input = Console.ReadLine();

        foreach (char c in input)
        {
            int index = Array.IndexOf(alphabet, c);
            Console.WriteLine($"{c} -> {index}");
        }
    }
}

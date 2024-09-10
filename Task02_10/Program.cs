using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] inputNumbers = Console.ReadLine().Split(' ');
        int difference = int.Parse(Console.ReadLine());

        int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);

        HashSet<int> numberSet = new HashSet<int>(numbers);

        int pairCount = 0;

        foreach (int num in numbers)
        {
            if (numberSet.Contains(num + difference))
            {
                pairCount++;
            }
            if (numberSet.Contains(num - difference) && difference != 0)
            {
                pairCount++;
            }
        }

        Console.WriteLine(pairCount / 2);
    }
}

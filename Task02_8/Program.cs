using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Dictionary<int, int> frequency = new Dictionary<int, int>();

        List<int> order = new List<int>();

        foreach (int num in arr)
        {
            if (frequency.ContainsKey(num))
            {
                frequency[num]++;
            }
            else
            {
                frequency[num] = 1;
                order.Add(num);
            }
        }

        int mostFrequent = -1;
        int maxFrequency = 0;

        foreach (int num in order)
        {
            if (frequency[num] > maxFrequency)
            {
                mostFrequent = num;
                maxFrequency = frequency[num];
            }
        }

        Console.WriteLine($"Число {mostFrequent} зустрічається частіше за все ({maxFrequency} разів)");
    }
}
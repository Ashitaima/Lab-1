using System;

class Program
{
    static void Main()
    {
        string[] inputNumbers = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(inputNumbers, int.Parse);

        int difference = int.Parse(Console.ReadLine());

        int pairCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (Math.Abs(numbers[i] - numbers[j]) == difference)
                {
                    pairCount++;
                }
            }
        }

        Console.WriteLine(pairCount);
    }
}

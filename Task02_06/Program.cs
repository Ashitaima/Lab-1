using System;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть числа:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int Start = 0;
        int Len = 1;

        int bestStart = 0;
        int bestLen = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1]) 
            {
                Len++;  
            }
            else
            {
                if (Len > bestLen)  
                {
                    bestLen = Len;
                    bestStart = Start;
                }
                Start = i;
                Len = 1;
            }
        }

        if (Len > bestLen)
        {
            bestLen = Len;
            bestStart = Start;
        }

        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

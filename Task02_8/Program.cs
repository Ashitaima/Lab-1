using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть числа, розділені пробілами:");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        int bestStart = 0;
        int bestLen = 1;
        int start = 0;
        int len = 1;

        for (int pos = 1; pos < numbers.Length; pos++)
        {
            if (numbers[pos] > numbers[pos - 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
                start = pos;
                len = 1;
            }
        }
        if (len > bestLen)
        {
            bestStart = start;
            bestLen = len;
        }

        Console.WriteLine("Найдовша зростаюча послідовність:");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}

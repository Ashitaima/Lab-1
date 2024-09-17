using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть числа");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int n = arr.Length;
        int[] len1 = [n];
        int start = 0;
        int len = 1;
        int beststart = 0;
        int bestlen = 1;
        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                len++;
            }
            else
            {
                if (len>bestlen)
                {
                    beststart = start;
                    bestlen = len;
                }
                start = i;
                len = 1;
            }
        }
        Console.WriteLine("Найдовша послідовність однакових елементів:");
        for (int i = beststart; i < beststart + bestlen; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

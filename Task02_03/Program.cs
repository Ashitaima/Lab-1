using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть числа для масиву даних");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = array.Length;
        int k = n / 4;

        int[] firstRow = new int[2 * k];

        for (int i = 0; i < k; i++)
        {
            firstRow[i] = array[k - 1 - i];
            firstRow[k + i] = array[n - 1 - i]; 
        }
        int[] secondRow = new int[2 * k];
        for (int i = 0; i < 2 * k; i++)
        {
            secondRow[i] = array[k + i];
        }

        int[] result = new int[2 * k];
        for (int i = 0; i < 2 * k; i++)
        {
            result[i] = firstRow[i] + secondRow[i];
        }
        Console.WriteLine(string.Join(" ", result));
    }
}

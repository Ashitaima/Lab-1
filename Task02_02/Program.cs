using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть числа для масиву даних");
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine("Введіть кількість обертів");
        int k = int.Parse(Console.ReadLine());

        int[] sum = new int[array.Length];
        for (int r = 0; r < k; r++)
        {
            int temp1 = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp1;
            for (int i = 0; i < array.Length; i++)
            {
                sum[i] += array[i];
            }
        }
        for (int w = 0; w < sum.Length; w++)
            {;
                Console.Write(sum[w] + " ");
            }
        }
    }



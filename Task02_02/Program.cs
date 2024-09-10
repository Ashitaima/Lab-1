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

        for (int rotation = 0; rotation < k; rotation++)
        {
            array = RotateRight(array);

            for (int i = 0; i < array.Length; i++)
            {
                sum[i] += array[i];
            }
        }
        Console.WriteLine("Sum: " + string.Join(" ", sum));
    }

    static int[] RotateRight(int[] array)
    {
        int[] rotated = new int[array.Length];
        rotated[0] = array[array.Length - 1];

        for (int i = 1; i < array.Length; i++)
        {
            rotated[i] = array[i - 1];
        }
        Console.WriteLine("Rotate: " + string.Join(" ", rotated));
        return rotated;
       
    }
}

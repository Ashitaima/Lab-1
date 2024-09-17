using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть перший масив символів через пробіл:");
        char[] arr1 = Console.ReadLine().Replace(" ", "").ToCharArray();

        Console.WriteLine("Введіть другий масив символів через пробіл:");
        char[] arr2 = Console.ReadLine().Replace(" ", "").ToCharArray();

        int minLength = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i] < arr2[i])
            {
                Console.WriteLine(new string(arr1));
                Console.WriteLine(new string(arr2));
                return;
            }
            else if (arr1[i] > arr2[i])
            {
                Console.WriteLine(new string(arr2));
                Console.WriteLine(new string(arr1));
                return;
            }
        }

        if (arr1.Length < arr2.Length)
        {
            Console.WriteLine(new string(arr1));
            Console.WriteLine(new string(arr2));
        }
        else if (arr1.Length > arr2.Length)
        {
            Console.WriteLine(new string(arr2));
            Console.WriteLine(new string(arr1));
        }
        else
        {
            Console.WriteLine(new string(arr1)); 
        }
    }
}
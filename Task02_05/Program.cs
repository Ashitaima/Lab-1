using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть перший масив символів через пробіл:");
        string[] arr1 = Console.ReadLine().Split(' ');

        Console.WriteLine("Введіть другий масив символів через пробіл:");
        string[] arr2 = Console.ReadLine().Split(' ');

        string result = Compare(arr1, arr2);
        Console.WriteLine(result);
    }

    static string Compare(string[] arr1, string[] arr2)
    {
        int minLength = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (arr1[i].CompareTo(arr2[i]) < 0)
            {
                return String.Join("", arr1) + " < " + String.Join("", arr2);
            }
            else if (arr1[i].CompareTo(arr2[i]) > 0)
            {
                return String.Join("", arr2) + " < " + String.Join("", arr1);
            }
        }

        if (arr1.Length < arr2.Length)
        {
            return String.Join("", arr1) + " < " + String.Join("", arr2);
        }
        else if (arr1.Length > arr2.Length)
        {
            return String.Join("", arr2) + " < " + String.Join("", arr1);
        }
        else
        {
            return String.Join("", arr1) + " = " + String.Join("", arr2);
        }
    }
}

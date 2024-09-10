using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть слова або речення для порівняння:");
        string[] firstArray = Console.ReadLine().Split(' ');
        string[] secondArray = Console.ReadLine().Split(' ');
        int commonLeft = GetCommonWordsCount(firstArray, secondArray);

        Array.Reverse(firstArray);
        Array.Reverse(secondArray);
        int commonRight = GetCommonWordsCount(firstArray, secondArray);

        if (commonLeft > commonRight && commonLeft > 0)
        {
            Console.WriteLine($"Найбільший спільний кінець є ліворуч: {commonLeft}");
        }
        else if (commonRight > commonLeft && commonRight > 0)
        {
            Console.WriteLine($"Найбільший спільний кінець є праворуч: {commonRight}");
        }
        else if (commonLeft == 0 && commonRight == 0)
        {
            Console.WriteLine("Немає спільних слів зліва та справа");
        }
    }

    static int GetCommonWordsCount(string[] firstArray, string[] secondArray)
    {
        int minLength = Math.Min(firstArray.Length, secondArray.Length);
        int commonCount = 0;

        for (int i = 0; i < minLength; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                commonCount++;
            }
            else
            {
                break;
            }
        }

        return commonCount;
    }
}

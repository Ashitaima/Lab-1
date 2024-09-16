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

        int minlength = Math.Min(firstArray.Length, secondArray.Length);
        int leftcount = 0;
        int rightcount = 0;
        for (int i = 0; i < minlength; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                leftcount++;
            }
            else break;
           
        }
        for (int i = 0; i < minlength; i++)
        {
            if (firstArray[firstArray.Length - 1 - i] == secondArray[secondArray.Length - 1 - i])
            {
                rightcount++;
            }
            else break;
        }
        if (leftcount > rightcount)
        { 
            Console.WriteLine($"Найбільший спільний кінець зліва: {leftcount}");
        for (int i = 0; i < leftcount; i++)
         {
            Console.Write(firstArray[i]);
            if (i < leftcount - 1) Console.Write(", ");
         }
        }
        else if (rightcount > leftcount)
        { 
            Console.WriteLine($"Найбільший спільний кінець справа: {rightcount}");
        for (int i = 0; i < rightcount; i++)
         {
            Console.Write(firstArray[i]);
            if (i < rightcount - 1) Console.Write(", ");
         }
        }
        else
            Console.WriteLine("Немає спільних");
    }
}

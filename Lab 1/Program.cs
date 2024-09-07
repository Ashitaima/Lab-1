using System;
using System.ComponentModel.Design;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть номер від 1 до 13 для вибору Завдання:");

        string input = Console.ReadLine();
        int choice;
        if (int.TryParse(input, out choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ви вибрали Завдання 1.\n");
                    sbyte a = -100;
                    byte b = 128;
                    short c = -3540;
                    ushort d = 64876;
                    uint e = 2147483648;
                    int f = -1141583228;
                    Console.WriteLine($"Числа:\n{a}\n{b}\n{c}\n{d}\n{e}\n{f}");
                    break;
                case 2:
                    Console.WriteLine("Ви вибрали Завдання 2.\n");
                    decimal d1 = 3.141592653589793238m;
                    double d2 = 1.60217657;
                    decimal d3 = 7.8184261974584555216535342341m;
                    Console.WriteLine($"Числа:\n{d1}\n{d2}\n{d3}");
                    break;
                case 3:
                    Console.WriteLine("Ви вибрали Завдання 3.\n");
                    string s1 = "Chernivtsi National University";
                    char b1 = 'B';
                    char y = 'y';
                    char e1 = 'e';
                    string ILP = "I love programming";
                    Console.WriteLine($"{s1}\n{b1}\n{y}\n{e1}\n{ILP}");
                    break;
                case 4:
                    Console.WriteLine("Ви вибрали Завдання 4.\n");
                    Console.WriteLine("Введіть числа для обчислення.");
                    float a1, b2, c3;
                    float average;
                    a1 = float.Parse(Console.ReadLine());
                    b2 = float.Parse(Console.ReadLine());
                    c3 = float.Parse(Console.ReadLine());
                    average = (a1 + b2 + c3) / 3;
                    Console.WriteLine(average);
                    break;
                case 5:
                    Console.WriteLine("Ви вибрали Завдання 5.\n");
                    Console.WriteLine("Введіть числа для обчислення площі трапеції.");
                    float a2, b3, h, area;
                    a2 = float.Parse(Console.ReadLine());
                    b3 = float.Parse(Console.ReadLine());
                    h = float.Parse(Console.ReadLine());
                    area = (a2 + b3) / 2 * h;
                    Console.WriteLine("Площа:" + area);
                    break;
                case 6:
                    int n, lastdigit;
                    Console.WriteLine("Ви вибрали Завдання 6.\n");
                    Console.WriteLine("Задайте число ");
                    n = int.Parse(Console.ReadLine());
                    lastdigit = n % 10;
                    Console.WriteLine("Остання цифра числа:" + lastdigit);
                    break;
                case 7:
                    Console.WriteLine("Ви вибрали Завдання 7.\n");
                    int number, n1, ndigit;
                    number = int.Parse(Console.ReadLine());
                    n1 = int.Parse(Console.ReadLine());
                    ndigit = (number / (int)Math.Pow(10, n1 - 1)) % (10);
                    Console.WriteLine("Ваша цифра:" + ndigit);
                    break;
                case 8:
                    Console.WriteLine("Ви вибрали Завдання 8.\n");
                    Console.WriteLine("Введіть число:");
                    int n9;
                    bool result9;
                    n9 = int.Parse(Console.ReadLine());
                    if (n9 > 20 && n9 % 10 == 1)
                    {
                        result9 = true;
                    }
                    else result9 = false;
                    Console.WriteLine("Відповідь:" + result9);
                    break;
                case 9:
                    Console.WriteLine("Ви вибрали Завдання 9.");
                    int n10;
                    bool result10;
                    n10 = int.Parse(Console.ReadLine());
                    if (n10 % 9 == 0 || n10 % 11 == 0 || n10 % 13 == 0)
                    {
                        result10 = true;
                    }
                    else
                        result10 = false;
                    Console.WriteLine("Результат:"+result10);
                    break;
                case 10:
                    Console.WriteLine("Ви вибрали Завдання 10.\n");
                    Console.WriteLine("Введіть числа для порівння");
                    int a11, b11, c11;
                    a11 = int.Parse(Console.ReadLine());
                    b11 = int.Parse(Console.ReadLine());
                    c11 = int.Parse(Console.ReadLine());
                    int max=a11;
                    if (b11 > max)
                    {
                        max = b11;
                    }
                    if (c11>max)
                    {
                        max = c11;
                    }
                    Console.WriteLine("Найбільше число:" + max);
                    break;
                case 11:
                    Console.WriteLine("Ви вибрали Завдання 11.\n");
                    double a12, b12, c12, product;
                    a12 = double.Parse(Console.ReadLine());
                    b12 = double.Parse(Console.ReadLine());
                    c12 = double.Parse(Console.ReadLine());
                    int negativeCount12 = 0;
                    if (a12 < 0)
                    {
                        negativeCount12++;
                    }
                    if (b12 < 0)
                    {
                        negativeCount12++;
                    }
                    if (c12 < 0)
                    {
                        negativeCount12++;
                    }
                    if (negativeCount12 == 1 || negativeCount12 == 3)
                    {
                        Console.WriteLine("Знак негативний.");
                    }
                    else if (negativeCount12 == 0 || negativeCount12 == 2)
                    {
                        Console.WriteLine("Знак позитивний.");
                    }
                    break;
                case 12:
                    Console.WriteLine("Ви вибрали Завдання 12.\n");
                    Console.WriteLine("Виберіть цифру від 1 до 7");
                    int n13;
                    n13 =int.Parse(Console.ReadLine());
                    switch (n13)
                    {
                        case 1:
                            Console.WriteLine("Monday");
                        break;
                        case 2:
                            Console.WriteLine("Tuesday");
                            break;
                        case 3:
                            Console.WriteLine("Wednesday");
                            break;
                        case 4:
                            Console.WriteLine("Thursday");
                            break;
                        case 5:
                            Console.WriteLine("Friday");
                            break;
                        case 6:
                            Console.WriteLine("Saturday");
                            break;
                        case 7:
                            Console.WriteLine("Sunday");
                            break;
                        default:
                            Console.WriteLine("не дійсний");
                            break;
                    }
                    break;
                case 13:
                    Console.WriteLine("Ви вибрали Завдання 13.\n");
                    int n14,factorial;
                    factorial = 1;
                    n14 =int.Parse(Console.ReadLine());
                    for (int i = 2; i <= n14; i++)
                    {
                        factorial = factorial * i;
                    }
                    Console.WriteLine("Факторіал числа:" + factorial);
                    break;
                default:
                    Console.WriteLine("Невірний вибір. Будь ласка, введіть число від 1 до 17.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Будь ласка, введіть коректне число.");
        }
    }
}

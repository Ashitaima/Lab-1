using System;
using System.Text;

class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public Person()
    {
        name = "Unknown";
        age = 0;
    }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;
        Person[] people = new Person[3];
        for (int i = 0; i < people.Length; i++)
        {
            Console.WriteLine($"Введіть ім'я для людини {i + 1}: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Введіть вік для людини {i + 1}: ");
            int age = int.Parse(Console.ReadLine());

            people[i] = new Person(name, age);
        }
        foreach (var person in people)
        {
            person.Display();

        }
    }
}
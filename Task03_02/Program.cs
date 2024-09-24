using System;
using System.Text;

class Person
{
    private string name;
    private int age;

    public Person() : this("No name", 1)
    { }
    public Person(int age) : this("No name", age)
    { }
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
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
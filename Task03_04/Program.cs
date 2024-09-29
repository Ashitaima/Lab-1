using System.Text;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Job { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public Employee(string name, double salary, string job, string department, string email, int age)
    {
        Name = name;
        Salary = salary;
        Job = job;
        Department = department;
        Email = email;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        Console.WriteLine("Введіть кількість співробітників:");
        int n = int.Parse(Console.ReadLine());
        Employee[] employees = new Employee[n];
        string[] departments = new string[n];
        double[] salaries = new double[n];
        int[] departmentCount = new int[n];
        int departmentIndex = 0;

        // Введення даних про співробітників
        Console.WriteLine("Введіть інформації про працівника (*обов'язково): *Ім'я *заробітня плата *посада *департамент, пошта, вік");
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string name = input[0];
            double salary = double.Parse(input[1]);
            string job = input[2];
            string department = input[3];

            string email = input.Length > 4 && input[4].Contains("@") ? input[4] : "n/a";
            int age = (input.Length > 5) ? int.Parse(input[5]) : (input.Length == 5 && int.TryParse(input[4], out int parsedAge) ? parsedAge : -1);

            employees[i] = new Employee(name, salary, job, department, email, age);

            int index = Array.IndexOf(departments, department);
            //Цей рядок шукає індекс першого входження назви відділу в масиві departments. Якщо такий відділ уже є в масиві, метод повертає його індекс, якщо немає — повертає -1.
            if (index == -1)
            {
                departments[departmentIndex] = department;
                salaries[departmentIndex] = salary;
                departmentCount[departmentIndex] = 1;
                departmentIndex++;
            }
            else
            {
                salaries[index] += salary;
                departmentCount[index]++;
            }
        }

        // Пошук відділу з найвищою середньою зарплатою
        double highestAverageSalary = 0;
        string highestSalaryDepartment = "";
        for (int i = 0; i < departmentIndex; i++)
        {
            double averageSalary = salaries[i] / departmentCount[i];
            if (averageSalary > highestAverageSalary)
            {
                highestAverageSalary = averageSalary;
                highestSalaryDepartment = departments[i];
            }
        }
        Console.WriteLine($"Найвища середня зарплатня: {highestSalaryDepartment}");
        foreach (var employee in employees)
        {
            if (employee.Department == highestSalaryDepartment)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}

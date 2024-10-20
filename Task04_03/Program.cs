using System;
using System.Collections.Generic;
using System.Linq;

class Hospital
{
    static void Main()
    {
        var departments = new Dictionary<string, List<string>>();
        var doctors = new Dictionary<string, List<string>>();
        var departmentRooms = new Dictionary<string, List<List<string>>>();

        // Обробка введених даних
        string input;
        while ((input = Console.ReadLine()) != "Output")
        {
            string[] parts = input.Split();
            string department = parts[0];
            string doctor = parts[1] + " " + parts[2];
            string patient = parts[3];

            // Якщо відділення ще не існує, створюємо його
            if (!departments.ContainsKey(department))
            {
                departments[department] = new List<string>();
                departmentRooms[department] = new List<List<string>>();
                for (int i = 0; i < 20; i++) // 20 палат
                {
                    departmentRooms[department].Add(new List<string>());
                }
            }

            // Якщо лікар ще не має записів, додаємо його
            if (!doctors.ContainsKey(doctor))
            {
                doctors[doctor] = new List<string>();
            }

            // Знаходимо перше вільне ліжко у відділенні
            bool isPlaced = false;
            foreach (var room in departmentRooms[department])
            {
                if (room.Count < 3) // 3 ліжка в палаті
                {
                    room.Add(patient);
                    isPlaced = true;
                    break;
                }
            }

            // Якщо є вільне місце, додаємо пацієнта до списків
            if (isPlaced)
            {
                departments[department].Add(patient);
                doctors[doctor].Add(patient);
            }
        }

        // Обробка команд Output
        while ((input = Console.ReadLine()) != "End")
        {
            string[] parts = input.Split();
            if (parts.Length == 1) // Вивести всіх пацієнтів відділення
            {
                string department = parts[0];
                if (departments.ContainsKey(department))
                {
                    foreach (var patient in departments[department])
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
            else if (parts.Length == 2 && int.TryParse(parts[1], out int roomNumber)) // Вивести пацієнтів палати
            {
                string department = parts[0];
                if (departmentRooms.ContainsKey(department))
                {
                    var room = departmentRooms[department][roomNumber - 1];
                    foreach (var patient in room.OrderBy(p => p))
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
            else if (parts.Length == 2) // Вивести пацієнтів лікаря
            {
                string doctor = parts[0] + " " + parts[1];
                if (doctors.ContainsKey(doctor))
                {
                    foreach (var patient in doctors[doctor].OrderBy(p => p))
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
        }
    }
}

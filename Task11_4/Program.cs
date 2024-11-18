using Task11_4.Model;
using static Task11_4.Weapon;

namespace Task11_4
{
    public class Program
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var parts = input.Split(';');
                var command = parts[0];

                switch (command)
                {
                    case "Create":
                        CreateWeapon(parts[1], parts[2]);
                        break;
                    case "Add":
                        AddGem(parts[1], int.Parse(parts[2]), parts[3]);
                        break;
                    case "Remove":
                        RemoveGem(parts[1], int.Parse(parts[2]));
                        break;
                    case "Print":
                        PrintWeapon(parts[1]);
                        break;
                }
            }
        }
    }
}

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

        private static void CreateWeapon(string rarityAndType, string name)
        {
            var rarityType = rarityAndType.Split(' ');
            var rarity = Enum.Parse<WeaponRarity>(rarityType[0]);
            var type = rarityType[1];

            Weapon weapon = type switch
            {
                "Axe" => new Weapon(name, 5, 10, 4, rarity),
                "Sword" => new Weapon(name, 4, 6, 3, rarity),
                "Knife" => new Weapon(name, 3, 4, 2, rarity),
                _ => throw new ArgumentException("Invalid weapon type")
            };

            weapons[name] = weapon;
        }
    }
}

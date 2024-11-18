using Task11_4.Model;
using Task11_4;
namespace Task11_4
{
    public class Weapon
    {
        private static Dictionary<string, Weapon> weapons = new Dictionary<string, Weapon>();
        public enum WeaponRarity
        {
            Common = 1,
            Uncommon = 2,
            Rare = 3,
            Epic = 5
        }

        public string Name { get; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set; }
        public int Sockets { get; }
        public WeaponRarity Rarity { get; }
        private Gem[] Gems;

        public Weapon(string name, int minDamage, int maxDamage, int sockets, WeaponRarity rarity)
        {
            Name = name;
            MinDamage = minDamage * (int)rarity;
            MaxDamage = maxDamage * (int)rarity;
            Sockets = sockets;
            Rarity = rarity;
            Gems = new Gem[sockets];
        }

        public void AddGem(int socketIndex, Gem gem)
        {
            if (socketIndex >= 0 && socketIndex < Sockets)
            {
                Gems[socketIndex] = gem;
            }
        }

        public void RemoveGem(int socketIndex)
        {
            if (socketIndex >= 0 && socketIndex < Sockets)
            {
                Gems[socketIndex] = null;
            }
        }

        public override string ToString()
        {
            int bonusStrength = Gems.Where(g => g != null).Sum(g => g.Strength);
            int bonusAgility = Gems.Where(g => g != null).Sum(g => g.Agility);
            int bonusVitality = Gems.Where(g => g != null).Sum(g => g.Vitality);

            int totalMinDamage = MinDamage + bonusStrength * 2 + bonusAgility * 1;
            int totalMaxDamage = MaxDamage + bonusStrength * 3 + bonusAgility * 4;

            return $"{Name}: {totalMinDamage}-{totalMaxDamage} Damage, +{bonusStrength} Strength, +{bonusAgility} Agility, +{bonusVitality} Vitality";
        }
        public static void AddGem(string weaponName, int socketIndex, string gemData)
        {
            if (weapons.ContainsKey(weaponName))
            {
                var gemParts = gemData.Split(' ');
                var clarity = Enum.Parse<GemClarity>(gemParts[0]);
                var gemType = Enum.Parse<GemType>(gemParts[1]);

                var gem = Gem.CreateGem(gemType, clarity);
                weapons[weaponName].AddGem(socketIndex, gem);
            }
        }

        public static void RemoveGem(string weaponName, int socketIndex)
        {
            if (weapons.ContainsKey(weaponName))
            {
                weapons[weaponName].RemoveGem(socketIndex);
            }
        }

        public static void PrintWeapon(string weaponName)
        {
            if (weapons.ContainsKey(weaponName))
            {
                Console.WriteLine(weapons[weaponName]);
            }
        }
        public static void CreateWeapon(string rarityAndType, string name)
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
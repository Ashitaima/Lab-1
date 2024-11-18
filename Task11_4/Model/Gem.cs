using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_4.Model
{
    public enum GemType
    {
        Ruby,
        Emerald,
        Amethyst
    }
    public enum GemClarity
    {
        Chipped = 1,
        Regular = 2,
        Perfect = 5,
        Flawless = 10
    }
    public class Gem
    {
        public int Strength { get; }
        public int Agility { get; }
        public int Vitality { get; }

        public Gem(int strength, int agility, int vitality, GemClarity clarity)
        {
            Strength = strength + (int)clarity;
            Agility = agility + (int)clarity;
            Vitality = vitality + (int)clarity;
        }

        public static Gem CreateGem(GemType gemType, GemClarity clarity)
        {
            return gemType switch
            {
                GemType.Ruby => new Gem(7, 2, 5, clarity),
                GemType.Emerald => new Gem(1, 4, 9, clarity),
                GemType.Amethyst => new Gem(2, 8, 4, clarity),
            };
        }
    }
}

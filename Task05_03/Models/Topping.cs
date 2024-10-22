using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_03.Models
{
    internal class Topping
    {
        private string type;
        private double weight;
        private const double CaloriesPerGram = 2;

        private readonly Dictionary<string, double> Modifiers = new Dictionary<string, double>
        {
            {"meat",1.2 },
            {"veggies",0.8 },
            {"cheese",1.1 },
            {"sauce", 0.9},
        };
        public Topping(string type,double weight)
        {
            string normType=type.ToLower();
            if (!Modifiers.ContainsKey(normType))
            {
                throw new ArgumentException($"Cannot place {type} on top of your pizza.");
            }
            if (weight < 1 || weight > 50)
            {
                throw new ArgumentException("Meat weight should be in the range [1..50]");
            }
            this.type = normType;
            this.weight = weight;
        }
        public double GetCalories()
        {
            return (CaloriesPerGram * weight) * Modifiers[type];
        }
    }
}

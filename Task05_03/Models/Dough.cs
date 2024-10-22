using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task05_03.Models
{
    internal class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private const double CaloriesPerGram = 2;

        private readonly Dictionary<string, double> Modifiers = new Dictionary<string, double>
        {
            {"white",1.5 },
            {"wholegrain",1.0 },
            {"crispy",0.9 },
            {"chewy", 1.1},
            {"homemade", 1.0 }
        };
        public Dough (string flourType,string bakingTechnique,double weight)
        {
            string normType = flourType.ToLower();
            string normTech = bakingTechnique.ToLower();
            if (!Modifiers.ContainsKey(normType))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            if (!Modifiers.ContainsKey(normTech))
            {
                throw new ArgumentException("Invalid type of baking Technique.");
            }

            if (weight < 1 || weight > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.flourType = normType;
            this.bakingTechnique = normTech;
            this.weight = weight;
        }
        public double GetCalories() 
        {
            return (CaloriesPerGram * weight) * Modifiers[flourType] * Modifiers[bakingTechnique];
        }
    }

}

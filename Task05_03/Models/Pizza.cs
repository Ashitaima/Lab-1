using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_03.Models
{
    internal class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;
        public Pizza(string name)
        {
            Name = name; 
            toppings = new List<Topping>();
        }
        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public Dough Dough
        {
            get { return dough; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Dough cannot be null.");
                }
                dough = value;
            }
        }
        public void AddTopping(Topping topping)
        {
            if (toppings.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }
        public double GetTotalCalories()
        {
            double totalCalories = dough.GetCalories();
            foreach (var topping in toppings)
            {
                totalCalories += topping.GetCalories();
            }
            return totalCalories;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1:F2} Calories.", Name, GetTotalCalories());
        }
    }
}
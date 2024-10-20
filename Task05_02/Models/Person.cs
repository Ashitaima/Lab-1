using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05_02.Models
{
    internal class Person
    {
        private string name;
        private int money;
        private List<Product> bag;
        public Person(string name, int money) { 
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>(); 
        }
        public string Name 
        { 
            get { return this.name; } 
            private set 
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public int Money
        {
            get
            {
                return this.money;
            }
            private set
            { 
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }
        public void BuyProduct(Product product)
        {
            if (this.Money >= product.Price)
            {
                this.bag.Add(product);
                this.Money -= product.Price;
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }
        }
        public string GetPurchaseHistory()
        {
            if (this.bag.Count == 0)
            {
                return $"{this.Name} hasn't bought anything.";
            }

            string purchaseList = $"{this.Name} bought: ";

            for (int i = 0; i < this.bag.Count; i++)
            {
                purchaseList += this.bag[i].Name; 
                if (i < this.bag.Count - 1)
                {
                    purchaseList += ", ";
                }
            }
            return purchaseList;
        }


    }
}

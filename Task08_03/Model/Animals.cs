using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task08_03.Model;

namespace Task08_03.Animal
{
    abstract class Animals
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        protected Animals(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }

        public abstract void AskForFood();
        public abstract void Eat(Food food);
        public abstract override string ToString();
    }

    abstract class Bird : Animals
    {
        public double WingSize { get; set; }

        protected Bird(string name, double weight, double wingSize) : base(name, weight)
        {
            WingSize = wingSize;
        }
    }

    abstract class Mammal : Animals
    {
        public string LivingRegion { get; set; }

        protected Mammal(string name, double weight, string livingRegion) : base(name, weight)
        {
            LivingRegion = livingRegion;
        }
    }

    abstract class Feline : Mammal
    {
        public string Breed { get; set; }

        protected Feline(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion)
        {
            Breed = breed;
        }
    }

    class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) { }

        public override void AskForFood()
        {
            Console.WriteLine("Meow");
        }

        public override void Eat(Food food)
        {
            if (food is Meat || food is Vegetable)
            {
                Weight += 0.3 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Cat does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"Cat [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }

    class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed) { }

        public override void AskForFood()
        {
            Console.WriteLine("ROAR!!!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Weight += 1.0 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"Tiger [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }

    class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize) { }

        public override void AskForFood()
        {
            Console.WriteLine("Hoot Hoot");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Weight += 0.25 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Owl does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"Owl [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }

    class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize) { }

        public override void AskForFood()
        {
            Console.WriteLine("Cluck");
        }

        public override void Eat(Food food)
        {
            Weight += 0.35 * food.Quantity;
            FoodEaten += food.Quantity;
        }

        public override string ToString()
        {
            return $"Hen [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }

    class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }

        public override void AskForFood()
        {
            Console.WriteLine("Squeak");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Fruit)
            {
                Weight += 0.1 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Mouse does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"Mouse [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }

    class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion) { }

        public override void AskForFood()
        {
            Console.WriteLine("Woof!");
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Weight += 0.4 * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Dog does not eat {food.GetType().Name}!");
            }
        }

        public override string ToString()
        {
            return $"Dog [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}

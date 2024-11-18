using Task08_03.Animal;
using Task08_03.Model;

namespace Task08_03
{
    internal class Program
    {
        static void Main()
        {
            var animals = new List<Animals>();

            string line;
            while ((line = Console.ReadLine()) != "End")
            {
                string[] animalInfo = line.Split();
                Animals animal = null;

                switch (animalInfo[0])
                {
                    case "Cat":
                        animal = new Cat(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                        break;
                    case "Tiger":
                        animal = new Tiger(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3], animalInfo[4]);
                        break;
                    case "Owl":
                        animal = new Owl(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                        break;
                    case "Hen":
                        animal = new Hen(animalInfo[1], double.Parse(animalInfo[2]), double.Parse(animalInfo[3]));
                        break;
                    case "Mouse":
                        animal = new Mouse(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        break;
                    case "Dog":
                        animal = new Dog(animalInfo[1], double.Parse(animalInfo[2]), animalInfo[3]);
                        break;
                }

                animals.Add(animal);

                string[] foodInfo = Console.ReadLine().Split();
                Food food = null;

                switch (foodInfo[0])
                {
                    case "Vegetable":
                        food = new Vegetable(int.Parse(foodInfo[1]));
                        break;
                    case "Fruit":
                        food = new Fruit(int.Parse(foodInfo[1]));
                        break;
                    case "Meat":
                        food = new Meat(int.Parse(foodInfo[1]));
                        break;
                    case "Seeds":
                        food = new Seeds(int.Parse(foodInfo[1]));
                        break;
                }

                animal.AskForFood();
                animal.Eat(food);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}

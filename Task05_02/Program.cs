namespace Task05_02
{
    using Task05_02.Models;
    internal class Program
    {
        static void Main()
        {
            try
            {
                // Люди
                var people = new List<Person>();
                string[] peopleInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var personData in peopleInput)
                {
                    string[] personDetails = personData.Split('=');
                    string name = personDetails[0];
                    int money = int.Parse(personDetails[1]);
                    people.Add(new Person(name, money));
                }

                // Продукти
                var products = new List<Product>();
                string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                foreach (var productData in productInput)
                {
                    string[] productDetails = productData.Split('=');
                    string name = productDetails[0];
                    int price = int.Parse(productDetails[1]);
                    products.Add(new Product(name, price));
                }

                // Процес покупок
                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    string[] purchaseDetails = command.Split();
                    string personName = purchaseDetails[0];
                    string productName = purchaseDetails[1];
                    Person person = null;
                    foreach (var p in people)
                    {
                        if (p.Name == personName)
                        {
                            person = p;
                            break;
                        }
                    }
                    Product product = null;
                    foreach (var p in products)
                    {
                        if (p.Name == productName)
                        {
                            product = p;
                            break; 
                        }
                    }

                    person.BuyProduct(product);
                }
                foreach (var person in people)
                {
                    Console.WriteLine(person.GetPurchaseHistory());
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}       
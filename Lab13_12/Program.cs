namespace Lab13_12
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var companies = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                input = input.Trim('|');
                var parts = input.Split(" - ");

                string companyName = parts[0].Trim();
                int amount = int.Parse(parts[1].Trim());
                string productName = parts[2].Trim();

                if (!companies.ContainsKey(companyName))
                {
                    companies[companyName] = new Dictionary<string, int>();
                }

                if (companies[companyName].ContainsKey(productName))
                {
                    companies[companyName][productName] += amount;
                }
                else
                {
                    companies[companyName][productName] = amount;
                }
            }

            foreach (var company in companies.OrderBy(c => c.Key))
            {
                var companyName = company.Key;
                var products = company.Value;
                Console.WriteLine($"{companyName}: {string.Join(", ", products.Select(p => $"{p.Key}-{p.Value}"))}");
            }
        }
    }
}

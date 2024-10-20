using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        long bagCapacity = long.Parse(Console.ReadLine());
        string[] items = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, long> gold = new Dictionary<string, long>();
        Dictionary<string, long> gems = new Dictionary<string, long>();
        Dictionary<string, long> cash = new Dictionary<string, long>();

        long totalGold = 0;
        long totalGems = 0;
        long totalCash = 0;

        for (int i = 0; i < items.Length; i += 2)
        {
            string item = items[i];
            long quantity = long.Parse(items[i + 1]);

            if (item.ToLower() == "gold")
            {
                if (totalGems + quantity <= totalGold + bagCapacity)
                {
                    if (!gold.ContainsKey(item))
                    {
                        gold[item] = 0;
                    }
                    gold[item] += quantity;
                    totalGold += quantity;
                }
            }
            else if (item.EndsWith("Gem") && item.Length > 3)
            {
                if (totalCash + quantity <= totalGems + bagCapacity)
                {
                    if (!gems.ContainsKey(item))
                    {
                        gems[item] = 0;
                    }
                    gems[item] += quantity;
                    totalGems += quantity;
                }
            }
            else if (item.Length == 3)
            {
                if (totalGold >= totalCash + quantity)
                {
                    if (!cash.ContainsKey(item))
                    {
                        cash[item] = 0;
                    }
                    cash[item] += quantity;
                    totalCash += quantity;
                }
            }
        }

        if (totalGold > 0)
        {
            Console.WriteLine($"<Gold> ${totalGold}");
            foreach (var item in gold.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"##{item.Key} - {item.Value}");
            }
        }

        if (totalGems > 0)
        {
            Console.WriteLine($"<Gem> ${totalGems}");
            foreach (var item in gems.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"##{item.Key} - {item.Value}");
            }
        }

        if (totalCash > 0)
        {
            Console.WriteLine($"<Cash> ${totalCash}");
            foreach (var item in cash.OrderByDescending(x => x.Key).ThenBy(x => x.Value))
            {
                Console.WriteLine($"##{item.Key} - {item.Value}");
            }
        }
    }
}

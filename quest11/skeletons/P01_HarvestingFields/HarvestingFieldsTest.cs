using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P01_HarvestingFields
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Type classType = typeof(HarvestingFields);

            while ((input = Console.ReadLine()) != "HARVEST")
            {
                FieldInfo[] fields = classType.GetFields(
                    BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

                switch (input)
                {
                    case "private":
                        PrintFields(fields.Where(f => f.IsPrivate));
                        break;

                    case "protected":
                        PrintFields(fields.Where(f => f.IsFamily));
                        break;

                    case "public":
                        PrintFields(fields.Where(f => f.IsPublic));
                        break;

                    case "all":
                        PrintFields(fields);
                        break;
                }
            }
        }

        static void PrintFields(IEnumerable<FieldInfo> fields)
        {
            foreach (var field in fields)
            {
                string accessModifier = field.IsPublic ? "public"
                    : field.IsFamily ? "protected"
                    : field.IsPrivate ? "private"
                    : "unknown";

                Console.WriteLine($"{accessModifier} {field.FieldType.Name} {field.Name}");
            }
        }
    }
}

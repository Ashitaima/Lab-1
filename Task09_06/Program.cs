using Task09_06.Model;
namespace Task09_06
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }

            string element = Console.ReadLine();
            Console.WriteLine(box.CountGreaterThan(element));
        }
    }
}

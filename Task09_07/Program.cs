using Task09_07.Model;
namespace Task09_07
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }

            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(box.CountGreaterThan(element));
        }
    }
}

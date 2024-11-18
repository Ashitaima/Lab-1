using Task09_03.Model;
namespace Task09_03
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}

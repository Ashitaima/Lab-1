using Task09_01.Model;

namespace Task09_01
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                Box<string> box = new Box<string>(s);
                Console.WriteLine(s);
            }

        }
    }
}

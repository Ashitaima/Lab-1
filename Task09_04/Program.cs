using Task09_04.Model;
namespace Task09_04
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<string>> boxes = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                boxes.Add(new Box<string>(input));
            }

            string[] swap = Console.ReadLine().Split();
            int index1 = int.Parse(swap[0]);
            int index2 = int.Parse(swap[1]);

            ListEx.Swap(boxes, index1, index2);
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}   

using Task09_05.Model;
namespace Task09_05
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                boxes.Add(new Box<int>(input));
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

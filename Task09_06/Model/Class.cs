using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09_06.Model
{
    public class Box<T> where T : IComparable<T>
    {
        private List<T> elements = new List<T>();

        public void Add(T element) 
        {
            elements.Add(element);
        }
        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (var item in elements)
            {
                if (item.CompareTo(element) > 0)
                    count++;
            }
            return count;
        }

    }
    public static class ListEx
    {
        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            T temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
    }
}

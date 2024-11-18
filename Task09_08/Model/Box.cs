using System;
using System.Collections;
using System.Collections.Generic;

namespace Task09_08.Model
{
    public class Box<T> : IEnumerable<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Remove(int index)
        {
            T item = items[index];
            items.RemoveAt(index);
            return item;
        }

        public bool Contains(T element)
        {
            return items.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T temp = items[index1];
            items[index1] = items[index2];
            items[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public T Max()
        {
            return items.Max();
        }

        public T Min()
        {
            return items.Min();
        }
        public void Print()
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public override string ToString()
        {
            return $"{typeof(T).FullName}: {string.Join(", ", items)}";
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<T> GetItems()
        {
            return items;
        }
    }
}

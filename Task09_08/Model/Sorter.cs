using System;
using System.Collections.Generic;

namespace Task09_08.Model
{
    public static class Sorter
    {
        public static void Sort<T>(Box<T> box) where T : IComparable<T>
        {
            List<T> elements = box.GetItems(); 
            elements.Sort(); 
        }
    }
}

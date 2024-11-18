using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09_01.Model
{
    public class Box<T>
    {
        private T value;

        public Box(T value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return $"{value.GetType().FullName}: {value}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_10.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Group { get; set; }

        public Person(string name, int group)
        {
            Name = name;
            Group = group;
        }
    }
}


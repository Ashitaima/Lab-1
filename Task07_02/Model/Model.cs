using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_02_01.Model
{
    public interface IIdentifiable
    {
        string Id { get; }
    }

    public class Citizen : IIdentifiable
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }

    public class Robot : IIdentifiable
    {
        public string Model { get; private set; }
        public string Id { get; private set; }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    } 
}

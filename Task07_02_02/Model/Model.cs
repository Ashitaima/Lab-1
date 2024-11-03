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

    public interface IBirth
    {
        string BirthDate { get; }
    }
    public class Citizen : IIdentifiable, IBirth
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string BirthDate { get; private set; }

        public Citizen(string name, int age, string id, string birthDate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDate;
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

    public class Pet : IBirth
    {
        public string Name { get; private set; }
        public string BirthDate { get; private set; }
        public Pet(string name, string birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }
    }
}

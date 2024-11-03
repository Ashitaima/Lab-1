using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07_03.Models
{
    public class Soldier : ISoldier
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Soldier(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}";
        }
    }

    public class Private : Soldier, IPrivate
    {
        public decimal Salary { get; private set; }

        public Private(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {Salary:F2}";
        }
    }

    public class LeutenantGeneral : Soldier, ILeutenantGeneral
    {
        public List<IPrivate> Privates { get; private set; }

        public LeutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            Privates = new List<IPrivate>();
        }

        public void AddPrivate(IPrivate privateSoldier)
        {
            Privates.Add(privateSoldier);
        }

        public override string ToString()
        {
            var privatesOutput = string.Join(Environment.NewLine, Privates.Select(p => "  " + p.ToString()));
            return base.ToString() + $"\nPrivates:\n{privatesOutput}";
        }
    }

    public class SpecialisedSoldier : Soldier, ISpecialisedSoldier
    {
        public string Corps { get; private set; }

        public SpecialisedSoldier(int id, string firstName, string lastName, string corps)
            : base(id, firstName, lastName)
        {
            Corps = corps;
        }
    }
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public List<Repair> Repairs { get; private set; }

        public Engineer(int id, string firstName, string lastName, string corps)
            : base(id, firstName, lastName, corps)
        {
            Repairs = new List<Repair>();
        }

        public void AddRepair(Repair repair)
        {
            Repairs.Add(repair);
        }

        public override string ToString()
        {
            var repairsOutput = string.Join(Environment.NewLine, Repairs.Select(r => "  " + r.ToString()));
            return base.ToString() + $"\nCorps: {Corps}\nRepairs:\n{repairsOutput}";
        }
    }

    public class Commando : SpecialisedSoldier, ICommando
    {
        public List<Mission> Missions { get; private set; }

        public Commando(int id, string firstName, string lastName, string corps)
            : base(id, firstName, lastName, corps)
        {
            Missions = new List<Mission>();
        }

        public void AddMission(Mission mission)
        {
            Missions.Add(mission);
        }

        public override string ToString()
        {
            var missionsOutput = string.Join(Environment.NewLine, Missions.Select(m => "  " + m.ToString()));
            return base.ToString() + $"\nCorps: {Corps}\nMissions:\n{missionsOutput}";
        }
    }

    public class Spy : Soldier, ISpy
    {
        public int CodeNumber { get; private set; }

        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCode Number: {CodeNumber}";
        }
    }

    public class Mission
    {
        public string CodeName { get; private set; }
        public string State { get; private set; }

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}";
        }
    }

    public class Repair
    {
        public string PartName { get; private set; }
        public int HoursWorked { get; private set; }

        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }

}

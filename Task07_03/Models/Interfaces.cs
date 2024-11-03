using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task07_03.Models
{
    public interface ISoldier
    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }

    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }

    public interface ILeutenantGeneral : ISoldier
    {
        List<IPrivate> Privates { get; }
    }

    public interface ISpecialisedSoldier : ISoldier
    {
        string Corps { get; }
    }

    public interface IEngineer : ISpecialisedSoldier
    {
        List<Repair> Repairs { get; }
    }

    public interface ICommando : ISpecialisedSoldier
    {
        List<Mission> Missions { get; }
    }

    public interface ISpy : ISoldier
    {
        int CodeNumber { get; }
    }
}

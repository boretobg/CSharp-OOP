using MilitaryElite.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        ICollection<IRepairs> Repairs { get; }
    }
}

using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SoldierCorps SoldierCorps { get; }
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, SoldierCorps soldierCorps) 
            : base(id, firstName, lastName, salary)
        {
            this.SoldierCorps = soldierCorps;
        }

    }
}

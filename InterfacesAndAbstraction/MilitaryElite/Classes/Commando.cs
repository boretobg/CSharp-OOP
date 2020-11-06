using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MilitaryElite.Classes
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public ICollection<IMission> missions { get; }

        public Commando(int id, string firstName, string lastName, decimal salary, SoldierCorps soldierCorps) 
            : base(id, firstName, lastName, salary, soldierCorps)
        {
            this.missions = new List<IMission>();
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary}");
            sb.AppendLine($"Corps: {SoldierCorps}");
            foreach (var item in missions)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}

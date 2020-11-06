using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MilitaryElite.Classes
{
    public class Mission : Commando, IMission, ICommando
    {
        public string CodeName { get; }
        MissionCorps MissionCorps { get; }

        public Mission(int id, string firstName, string lastName, decimal salary, string codeName) 
            : base(id, firstName, lastName, salary)
        {
            this.CodeName = codeName;
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {MissionCorps}";
        }
    }
}

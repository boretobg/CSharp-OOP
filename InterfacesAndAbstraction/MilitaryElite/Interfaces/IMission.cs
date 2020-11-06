using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    public interface IMission
    {
        public string CodeName { get; }
        MissionCorps MissionCorps { get; }

        public void CompleteMission()
        {
            
        }
    }
}

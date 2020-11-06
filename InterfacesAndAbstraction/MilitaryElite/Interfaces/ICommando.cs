using MilitaryElite.Classes;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {
        ICollection<IMission> missions { get; }
    }
}

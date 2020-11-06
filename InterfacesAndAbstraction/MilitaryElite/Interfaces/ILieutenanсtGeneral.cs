using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    interface ILieutenanсtGeneral
    {
        ICollection<IPrivate> Privates { get; }
    }
}

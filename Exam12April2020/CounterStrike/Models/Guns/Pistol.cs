using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun
    {
        private int bulletStrike { get; }
        public Pistol(string name, int bulletCount) : base(name, bulletCount)
        {
        }
    }
}

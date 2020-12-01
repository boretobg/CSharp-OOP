using CounterStrike.Models.Guns.Contracts;
using System;

namespace CounterStrike.Models.Guns
{
    public class Pistol : Gun, IGun
    {

        public Pistol(string name, int bulletCount) : base(name, bulletCount)
        {
        }

        public override int Fire()
        {
            if (BulletsCount > 0)
            {
                BulletsCount--;
                return 1;
            }

            return 0;
        }
    }
}

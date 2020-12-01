using CounterStrike.Models.Guns.Contracts;
using System;

namespace CounterStrike.Models.Guns
{
    public class Rifle : Gun, IGun
    {
        public Rifle(string name, int bulletCount) : base(name, bulletCount)
        {
        }

        public override int Fire()
        {
            if (BulletsCount >= 10)
            {
                BulletsCount -= 10;
                return 10;

            }

            return 0;
        }
    }
}

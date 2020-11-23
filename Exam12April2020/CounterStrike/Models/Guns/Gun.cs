using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    using CounterStrike.Models.Guns.Contracts;
    using CounterStrike.Utilities.Messages;

    public class Gun : ExceptionMessages, IGun
    {
        private string name;
        private int bulletCount;

        public Gun(string name, int bulletCount)
        {
            Name = name;
            BulletsCount = bulletCount;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ExceptionMessages().InvalidPlayerName();
                }
                this.name = value;
            }
        }

        public int BulletsCount { get; set; }


        public int Fire()
        {
            throw new NotImplementedException();
        }
    }
}

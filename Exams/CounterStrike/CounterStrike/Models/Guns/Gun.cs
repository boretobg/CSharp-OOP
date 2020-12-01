using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Utilities.Messages;
using System;

namespace CounterStrike.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletCount;

        protected Gun(string name, int bulletCount)
        {
            this.Name = name;
            this.BulletsCount = bulletCount;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunName);
                }

                this.name = value;
            }
        }

        public int BulletsCount
        {
            get => this.bulletCount;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGunBulletsCount);
                }

                this.bulletCount = value;
            }
        }

        public abstract int Fire();
    }
}

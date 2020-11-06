using MilitaryElite.Classes;
using MilitaryElite.Interfaces;
using System;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            //Private 1 Pesho Peshev 22.22
            //Commando 13 Stamat Stamov 13.1 Airforces
            //Private 222 Toncho Tonchev 80.08
            //LieutenantGeneral 3 Joro Jorev 100 222 1
            //End
            ISoldier soldier = new Private(1, "Pesho", "Peshev", 22.22M);
            ISoldier soldier1 = new Commando(13, "Stamat", "Stamov", 13.1M, Enums.SoldierCorps);
        }
    }
}

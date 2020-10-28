using System.Dynamic;
using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Spiderman", 20);
            SoulMaster soulMaster = new SoulMaster("Ivan", 34423);
            Console.WriteLine(soulMaster.ToString());
        }
    }
}
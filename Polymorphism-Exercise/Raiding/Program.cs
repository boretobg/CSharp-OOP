using Raiding.Contracts;
using Raiding.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class Program
    {
        static void Main()
        {
            var listOfHeroes = new List<BaseHero>();
            BaseHero hero;

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                switch (heroType)
                {
                    case "Druid":
                        hero = new Druid(heroName);
                        break;
                    case "Paladin":
                        hero = new Paladin(heroName);
                        break;
                    case "Rogue":
                        hero = new Rogue(heroName);
                        break;
                    case "Warrior":
                        hero = new Warrior(heroName);
                        break;
                    default:
                        Console.WriteLine("Invalid hero!");
                        continue;
                }
                listOfHeroes.Add(hero);
            }

            foreach (var item in listOfHeroes)
            {
                Console.WriteLine(item.CastAbility());
            }

            int bossPower = int.Parse(Console.ReadLine());
            bool isWinner = listOfHeroes.Sum(h => h.Power) >= bossPower;
            Console.WriteLine(isWinner ? "Victory!" : "Defeat...");
        }
    }
}

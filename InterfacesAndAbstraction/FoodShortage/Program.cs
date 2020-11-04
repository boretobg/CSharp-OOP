using System;
using System.Collections.Generic;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen citizensList = new Citizen();
            Rebel rebelsList = new Rebel();

            Citizen citizen = new Citizen();
            Rebel rebel = new Rebel();


            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                if (input.Length == 4)
                {
                    citizen = new Citizen(input[0], int.Parse(input[1]), input[2], input[3]);
                    citizensList.citizens.Add(citizen);
                }
                else
                {
                    rebel = new Rebel(input[0], int.Parse(input[1]), input[2]);
                    rebelsList.rebels.Add(rebel);
                }
            }

            string line = Console.ReadLine();
            while (line != "End")
            {
                for (int i = 0; i < citizensList.citizens.Count; i++)
                {
                    if (citizensList.citizens[i].name == line)
                    {
                        citizen.BuyFood();
                    }
                }

                for (int i = 0; i < rebelsList.rebels.Count; i++)
                {
                    if (rebelsList.rebels[i].name == line)
                    {
                        rebel.BuyFood();
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine((citizen.Food) + (rebel.Food));
        }
    }
}

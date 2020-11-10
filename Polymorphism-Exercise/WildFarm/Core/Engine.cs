using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using WildFarm.Contracts;
using WildFarm.Models;

namespace WildFarm.Core
{
    public class Engine
    {
        public void Start()
        {
            Animal animal = null;
            var animalList = new List<Animal>();
            int count = 0;
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] line = input.Split();

                if (count % 2 == 0)
                {
                    string type = line[0];
                    switch (type)
                    {
                        case "Owl":
                            animal = new Owl(line[1], double.Parse(line[2]), double.Parse(line[3]));
                            break;
                        case "Hen":
                            animal = new Hen(line[1], double.Parse(line[2]), double.Parse(line[3]));
                            break;
                        case "Mouse":
                            animal = new Mouse(line[1], double.Parse(line[2]), line[3]);
                            break;
                        case "Dog":
                            animal = new Dog(line[1], double.Parse(line[2]), line[3]);
                            break;
                        case "Cat":
                            animal = new Cat(line[1], double.Parse(line[2]), line[3], line[4]);
                            break;
                        case "Tiger":
                            animal = new Tiger(line[1], double.Parse(line[2]), line[3], line[4]);
                            break;
                    }
                    animalList.Add(animal);
                    Console.WriteLine(animal.Sound);
                }
                else
                {
                    string food = line[0];
                    int quantity = int.Parse(line[1]);

                    bool canEat = false;
                    foreach (var item in animal.Eats)
                    {
                        if (item == food)
                        {
                            canEat = true;
                        }
                    }

                    if (!canEat)
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {food}!");
                        count++;
                        continue;
                    }

                    animal.Weight += animal.WeightGainer * quantity;
                    animal.FoodEaten += quantity;
                }

                count++;
            }

            foreach (var item in animalList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}

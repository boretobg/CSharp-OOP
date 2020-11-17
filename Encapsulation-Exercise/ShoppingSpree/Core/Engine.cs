using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree.Core
{
    public class Engine
    {
        public void Start()
        {
            //Pesho = 11;Gosho = 4
            //Bread = 10;Milk = 2;

            var persons = new List<Person>();
            var products = new List<Product>();

            string[] input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    string[] line = input[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    Person person = new Person(line[0], decimal.Parse(line[1]));
                    persons.Add(person);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            input = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    string[] line = input[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    Product product = new Product(line[0], decimal.Parse(line[1]));
                    products.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            int index = 0;
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] line = command.Split();
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Name == line[1])
                    {
                        index = i;
                    }
                }
                for (int i = 0; i < persons.Count; i++)
                {
                    if (persons[i].Name == line[0])
                    {
                        if (persons[i].Money >= products[index].Cost)
                        {
                            persons[i].bagOfProducts.Add(products[index]);
                            persons[i].Money -= products[index].Cost;
                            Console.WriteLine($"{persons[i].Name} bought {products[index].Name}");
                        }
                        else
                        {
                            Console.WriteLine($"{persons[i].Name} can't afford {products[index].Name}");
                        }
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var person in persons)
            {
                if (person.bagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                    continue;
                }
                string[] productNames = new string[person.bagOfProducts.Count];
                for (int i = 0; i < person.bagOfProducts.Count; i++)
                {
                    productNames[i] = person.bagOfProducts[i].Name;
                }

                Console.WriteLine($"{person.Name} - {string.Join(", ", productNames)}");
            }

        }
    }
}

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    public class Engine
    {
        private readonly ICollection<Person> people;
        private readonly ICollection<Product> products;

        public Engine()
        {
            this.people = new List<Person>();
            this.products = new List<Product>();
        }
        public void Buying()
        {
            try
            {
                this.PersonInput();
                this.ProductInput();

                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string personName = info[0];
                    string productName = info[1];

                    Person person = this.people.FirstOrDefault(p => p.Name == personName);
                    Product product = this.products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        person.BuyProduct(product);
                    }
                    input = Console.ReadLine();
                }

                foreach (Person person in this.people)
                {
                    Console.WriteLine(person);
                }

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
        public void PersonInput()
        {
            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                string[] data = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person(data[0], double.Parse(data[1]));
                this.people.Add(person);
            }
        }
        public void ProductInput()
        {
            string[] input = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in input)
            {
                string[] data = item.Split("=", StringSplitOptions.RemoveEmptyEntries);
                Product product = new Product(data[0], double.Parse(data[1]));
                this.products.Add(product);
            }
        }
    }
}

using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = string.Empty;
            while (true)
            {
                string type = Console.ReadLine();
                if (type == "Beast!")
                {
                    break;
                }
                input = Console.ReadLine();
                string[] line = input.Split();
                Animals animal = null;
                try
                {
                    switch (type)
                    {
                        case "Dog":
                            animal = new Dog(line[0], int.Parse(line[1]), line[2]);
                            break;
                        case "Cat":
                            animal = new Cat(line[0], int.Parse(line[1]), line[2]);
                            break;
                        case "Frog":
                            animal = new Frog(line[0], int.Parse(line[1]), line[2]);
                            break;
                        case "Kitten":
                            animal = new Kitten(line[0], int.Parse(line[1]));
                            break;
                        case "Tomcat":
                            animal = new Tomcat(line[0], int.Parse(line[1]));
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                
                Console.WriteLine(animal.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern.Core.Contracts
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                //read data from console
                string input = Console.ReadLine();
                //pass it to proper CommandInterpreter and receive it
                var result = commandInterpreter.Read(input);
                //print output data
                Console.WriteLine(result);
            }

        }
    }
}

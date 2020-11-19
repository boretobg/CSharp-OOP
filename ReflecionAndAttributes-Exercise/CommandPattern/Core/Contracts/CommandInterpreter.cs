using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core.Contracts
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            //read
            var input = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string cmd = input[0].ToLower();
            string[] elements = input.Skip(1).ToArray();

            string result = string.Empty;

            //getting types
            var type = Assembly.GetCallingAssembly().GetTypes();
            //finding the type
            Type targetClass = type.FirstOrDefault(t => t.Name.ToLower().Contains(cmd));
            //creating instance of the type to use the built in method (Executw)
            ICommand currentClass = (ICommand)Activator.CreateInstance(targetClass);
            //receive data
            result = currentClass.Execute(elements);
            //return data to engine
            return result;
        }
    }
}

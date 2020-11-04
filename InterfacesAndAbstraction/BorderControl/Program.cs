using System;
using System.Collections.Generic;

namespace BorderControl
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDs ids = new IDs();
            ids.idList = InputData();

            ids.IdCheck(Console.ReadLine());
        }

        public static List<string> InputData()
        {
            var list = new List<string>();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var line = input.Split();
                list.Add(line[line.Length - 1]); // adds the last element (the id)
            }

            return list;
        }
    }
}

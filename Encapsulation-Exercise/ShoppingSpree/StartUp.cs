using ShoppingSpree.Core;
using System;

namespace ShoppingSpree
{
     public class StartUp
    {
        public static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Start();
        }
    }
}

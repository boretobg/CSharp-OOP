using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Frog : Animals
    {
        public const string sound = "Ribbit";
        public Frog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string Sound { get => sound; }
    }
}

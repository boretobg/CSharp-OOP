using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Kitten : Cat
    {
        public new const string sound = "Meow";

        public Kitten(string name, int age) : base(name, age, string.Empty)
        {
        }
       
        public override string Gender { get => "Female"; }
        public override string Sound => sound;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        public new const string sound = "MEOW";

        public Tomcat(string name, int age) : base(name, age, string.Empty)
        {
        }

        public override string Gender { get => "Male"; }
        public override string Sound => sound;
    }
}

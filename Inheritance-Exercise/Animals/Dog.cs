﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Dog : Animals
    {
        public const string sound = "Woof!";

        public Dog(string name, int age, string gender) : base(name, age, gender)
        {
        }

        public override string Sound { get => sound; }
    }
}

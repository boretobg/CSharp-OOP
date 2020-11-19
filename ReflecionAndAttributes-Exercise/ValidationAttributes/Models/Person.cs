using System;
using System.Collections.Generic;
using System.Text;
using ValidationAttributes.Attributes;

namespace ValidationAttributes.Models
{
    public class Person
    {
        public Person(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

        [MyRange(12, 90)]
        public int Age { get; set; }

        [MyRequired]
        public string FullName { get; set; }

    }
}

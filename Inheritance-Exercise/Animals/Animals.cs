using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animals
    {
        private string name;
        private int age;
        private string gender;

        public Animals(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual string Sound { get; set; }
        public virtual string Name { get { return this.name; } set { this.name = value; } }
        public virtual int Age 
        { get 
            { 
                return this.age; 
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value; 
            } 
        }
        public virtual string Gender { get { return this.gender; } set { this.gender = value; } }

        public virtual string ProduceSound()
        {
            return this.Sound;
        }

        public override string ToString()
        {
            return $"{GetType().Name}\n{Name} {Age} {Gender}\n{ProduceSound()}";
        }
    }
}

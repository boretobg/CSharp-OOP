using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomException
{
    public class Student
    {
        private string name;
        private string email;

        public Student(string name, string email)
        {
            Name = name;
            this.email = email;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                var regexItem = new Regex("^[a-zA-Z0-9 ]*$");
                if (!regexItem.IsMatch(value))
                {
                    throw new InvalidPersonNameException("Name contains invalid characters!!!");
                }

                this.name = value;
            }
        }
    }
}

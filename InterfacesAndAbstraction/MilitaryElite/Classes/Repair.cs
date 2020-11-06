using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Classes
{
    class Repair : IRepairs
    {
        public string PartName { get; }

        public int HoursWorked { get; }

        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorked}";
        }
    }
}

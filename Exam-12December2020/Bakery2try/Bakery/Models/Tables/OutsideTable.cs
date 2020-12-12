using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public class OutsideTable : Table
    {
        public OutsideTable(int tableNumber, int capacity )
            : base(tableNumber, capacity)
        {
        }

        public override decimal PricePerPerson { get; protected set; } = 3.50m;
    }
}

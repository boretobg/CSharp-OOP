using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Tables
{
    public class InsideTable : Table
    {
        public InsideTable(int tableNumber, int capacity )
            : base(tableNumber, capacity)
        {
        }

        public override decimal PricePerPerson { get; protected set; } = 2.50m;
    }
}

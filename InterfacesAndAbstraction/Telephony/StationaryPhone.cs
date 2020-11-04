using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : ICallOtherPhones
    {
        public void CallOtherPhones(string number)
        {
            Console.WriteLine($"Dialing... {number}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : IBrowseWeb
    {
        public void CallOtherPhones(string number)
        {
            Console.WriteLine($"Calling... {number}");
        }

        public void BrowseWeb(string site)
        {
            Console.WriteLine($"Browsing: {site}!");
        }
    }
}

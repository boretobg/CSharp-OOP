using System;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var phoneNubmers = Console.ReadLine().Split();
            for (int i = 0; i < phoneNubmers.Length; i++)
            {
                if (!NumberValidation(phoneNubmers[i]))
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                if (phoneNubmers[i].Length == 10)
                {
                    ICallOtherPhones calling = new Smartphone();
                    calling.CallOtherPhones(phoneNubmers[i]);
                }
                else if (phoneNubmers[i].Length == 7)
                {
                    ICallOtherPhones calling = new StationaryPhone();
                    calling.CallOtherPhones(phoneNubmers[i]);
                }
            }

            var websites = Console.ReadLine().Split();
            for (int i = 0; i < websites.Length; i++)
            {
                if (!WebsiteValidation(websites[i]))
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }
                IBrowseWeb browsing = new Smartphone();
                browsing.BrowseWeb(websites[i]);
            }
        }

        public static bool NumberValidation(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] < '0' || number[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        public static bool WebsiteValidation(string site)
        {
            for (int i = 0; i < site.Length; i++)
            {
                if (site[i] >= '0' && site[i] <= '9')
                {
                    return false;
                }
            }
            return true;
        }
    }
}

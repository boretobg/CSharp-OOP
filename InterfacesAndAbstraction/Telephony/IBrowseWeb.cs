using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface IBrowseWeb : ICallOtherPhones
    {
        void BrowseWeb(string site);
        
    }
}

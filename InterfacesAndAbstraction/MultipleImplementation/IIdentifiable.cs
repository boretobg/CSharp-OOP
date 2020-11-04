using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace PersonInfo
{
    public interface IIdentifiable
    {
        public string  Id { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IBirthable : IIdentifiable
    {
        public string Birthdate { get; set; }
    }
}

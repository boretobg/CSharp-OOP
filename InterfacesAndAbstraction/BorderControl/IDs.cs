using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class IDs : IIdCheker
    {
        public ICollection<string> idList;

        public IDs()
        {
            idList = new List<string>();
        }
        public void IdCheck(string target)
        {
            foreach (var item in this.idList)
            {
                if (item.EndsWith(target))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public void RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(base.Count);
            Console.WriteLine(base[index]);
            base.RemoveAt(index);
        }
    }
}

using System;

namespace Fixing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = new string[5];
            weekDays[0] = "Sunday";
            weekDays[1] = "Monday";
            weekDays[2] = "Tuesdat";
            weekDays[3] = "Wednesday";
            weekDays[4] = "Thursday";

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    if (i >= weekDays.Length)
                    {
                        throw new ArgumentException("OUTSIDE OF BOUNDS");
                    }
                    Console.WriteLine(weekDays[i].ToString());
                }
                Console.ReadLine();
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
        }
    }
}

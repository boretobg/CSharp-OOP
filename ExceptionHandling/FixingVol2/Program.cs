using System;

namespace FixingVol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 60;
            num2 = 30;
            
            try
            {
                if (num1 * num2 > 255)
                {
                    throw new ArgumentException("OVERFLOW");
                }
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine($"{num1} * {num2} = {result}");
                Console.ReadLine();
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
        }
    }
}

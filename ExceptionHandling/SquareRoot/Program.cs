using System;
using System.Security.Cryptography.X509Certificates;

namespace SquareRoot
{
    class Program
    {
        public const string MSG = "Invalid number";
        static void Main(string[] args)
        {
            

            try
            {
                int n = int.Parse(Console.ReadLine());
                double sqr = Math.Sqrt(n);
                if (n < 0)
                {
                    throw new ArgumentException(MSG);
                }
                Console.WriteLine(sqr);
            }
            catch(FormatException fe)
            {
                Console.WriteLine(MSG);
                throw fe;
            }
            catch (ArgumentException ae)
            {
                throw ae;
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

        }
    }
}

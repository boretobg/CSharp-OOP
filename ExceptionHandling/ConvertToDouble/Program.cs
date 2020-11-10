using System;
using System.Reflection.Metadata;

namespace ConvertToDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string toConvert = Console.ReadLine();
                double converted = Convert.ToDouble(toConvert);
                Console.WriteLine(converted);
            }
            catch (FormatException)
            {
                Console.WriteLine("INVALID FORMAT");
                throw;
            }
            catch (OverflowException)
            {
                Console.WriteLine("OVEFLOW");
                throw;
            }
            finally
            {
                Console.WriteLine("End of program....");
            }
        }
    }
}

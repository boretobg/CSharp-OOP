using System;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCompleted = false;
            while (!isCompleted)
            {
                try
                {
                    int start = int.Parse(Console.ReadLine());
                    int end = int.Parse(Console.ReadLine());
                    ReadNumber(start, end);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine("Invalid number");
                    throw ae;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format");
                    throw;
                }
                isCompleted = true;
            }
            
        }

        static void ReadNumber(int start, int end)
        {
            

            for (int i = start; i <= end; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 100)
                {
                    throw new ArgumentException("Invalid number");
                }
            }
        }
    }
}

using System;

namespace ValidPerson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", "Peshev", 24);
            //Person noName = new Person(string.Empty, "Goshev", 31);
            try
            {
                //Person noLastName = new Person("Ivan", null, 21);
                //Person negativeAge = new Person("Gero", "Mirov", -23);
                Person tooOldForThisProgram = new Person("Pepi", "Staroto", 234);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }
        }
    }
}

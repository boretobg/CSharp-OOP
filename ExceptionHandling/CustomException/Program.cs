using System;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Bobby", "asdad@adsa.vfbg");

            try
            {
                Student wrongStudent = new Student("Bo&&#", "asd@abv.bg");
            }
            catch (InvalidPersonNameException ipne)
            {
                Console.WriteLine(ipne.Message);
            }
        }
    }
}

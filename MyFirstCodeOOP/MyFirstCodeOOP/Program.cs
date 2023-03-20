using System;

namespace MyFirstCodeOOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creacion del objeto
            try
            {
                var dateObject = new Date(2002, 12, 3);
                Console.WriteLine(dateObject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            //Console.WriteLine("");
        }
    }
}

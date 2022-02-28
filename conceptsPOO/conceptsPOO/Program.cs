using System;

namespace conceptsPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(new Date(2022, 10, 20));
                Console.WriteLine(new Date(2022, 11, 20));
                Console.WriteLine(new Date(2022, 9, 20));
                Console.WriteLine(new Date(2024, 2, 29));
            }
            catch (Exception Error)
            {

                Console.WriteLine(Error.Message);
            }
            Console.WriteLine("Finalizado");
            Console.ReadKey();
        }

        
    }
}

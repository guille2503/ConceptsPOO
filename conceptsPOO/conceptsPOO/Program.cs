using System;

namespace conceptsPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new SalaryEmployee()
            {
                Id = 1010,
                FirstName = "Sandra",
                LastName = "Morales",
                BirthDate = new Date(1990, 5, 23),
                HiringDate = new Date(2022, 1, 15),
                IsActive = true,
                Salary = 1815453.2M
            };
            Console.WriteLine(employee1);
            Employee employee2 = new CommissionEmployee()
            {
                Id = 2020,
                FirstName = "Patricia",
                LastName = "Gutierrez",
                BirthDate = new Date(1995, 5, 23),
                HiringDate = new Date(2022, 2, 15),
                IsActive = true,
                Sales = 320000000M,
                CommissionPorcentaje = 0.03F
            };
            Console.WriteLine(employee2);

            Console.WriteLine("Finalizado");
            Console.ReadKey();
        }

        
    }
}

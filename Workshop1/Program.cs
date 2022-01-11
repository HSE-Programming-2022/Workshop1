using System;
using Workshop1.Test;


namespace Workshop1
{
    class Program
    { 
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            string salaryStr = Console.ReadLine();
            double salary = Double.Parse(salaryStr);
            bool isForeigner = bool.Parse(Console.ReadLine());

            Employee employee = new Employee()
            {
                Name = name,
                Salary = salary
            };

            double salaryAfterTax = 0;
            if (isForeigner)
            {
                salaryAfterTax = employee.Salary * (1 - 0.3);
            }
            else
            {
                salaryAfterTax = employee.Salary * (1 - 0.13);
            }

            Console.WriteLine(salaryAfterTax);

            Console.ReadKey();
        }
    }
}

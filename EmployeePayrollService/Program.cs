using System;

namespace EmployeePayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to payroll services using ADO");

            //EmployeeRepo repository = new EmployeeRepo();
            //Console.WriteLine("Id Name BasicPay Startdate Gender Department PhoneNumber Address Deduction Tax IncomeTax NetPay \n");
            //repository.GetAllEmployee();
            //Console.ReadLine();

            EmployeeRepo repository = new EmployeeRepo();
            repository.UpdateSalary();
            Console.ReadLine();
        }
    }
}


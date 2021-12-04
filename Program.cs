using System;
using System.Data.SqlClient;

namespace ADO_PayrollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADO payroll service");
            //Create oobject for Employee Repository
            EmployeeRepo employeeRepository = new EmployeeRepo();
            employeeRepository.GetSqlData();
        }
    }
}

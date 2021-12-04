using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADO_Employee_Payroll
{
    class EmployeeRepo
    {
        //Give path for Database Connection
        public static string connection = @"Server=WASIF;Database=payroll_services;Trusted_Connection=True;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
    }
}
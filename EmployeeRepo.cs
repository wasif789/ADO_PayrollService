using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ADO_PayrollService
{
    class EmployeeRepo
    {
        //Give path for Database Connection
        public static string connection = @"Server=WASIF;Database=payroll_services;Trusted_Connection=True;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
        //Create Object for EmployeeData Repository
        EmployeeManager employeeDataManager = new EmployeeManager();
        public void GetSqlData()
        {
            //Open Connection
            sqlConnection.Open();
            string query = "select * from employee_payroll";
            //Pass query to TSql
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            //Check if swlDataReader has Rows
            if (sqlDataReader.HasRows)
            {
                //Read each row
                while (sqlDataReader.Read())
                {
                    //Read data SqlDataReader and store 
                    employeeDataManager.EmployeeID = Convert.ToInt32(sqlDataReader["empId"]);
                    employeeDataManager.EmployeeName = Convert.ToString(sqlDataReader["name"]);
                    employeeDataManager.BasicPay = Convert.ToInt32(sqlDataReader["Basic Pay"]);
                    employeeDataManager.Deduction = Convert.ToInt32(sqlDataReader["Deductions"]);
                    employeeDataManager.IncomeTax = Convert.ToInt32(sqlDataReader["IncomeTax"]);
                    employeeDataManager.TaxablePay = Convert.ToInt32(sqlDataReader["Basic Pay"]);
                    employeeDataManager.NetPay = Convert.ToInt32(sqlDataReader["NetPay"]);
                    employeeDataManager.Gender = Convert.ToChar(sqlDataReader["Gender"]);
                    employeeDataManager.EmployeePhoneNumber = Convert.ToInt64(sqlDataReader["Basic Pay"]);
                    employeeDataManager.EmployeeDepartment = Convert.ToString(sqlDataReader["Department"]);
                    employeeDataManager.Address = Convert.ToString(sqlDataReader["Address"]);

                    //Display Data
                    Console.WriteLine("\nEmployee ID: {0} \t Employee Name: {1} \nBasic Pay: {2} \t Deduction: {3} \t Income Tax: {4} \t Taxable Pay: {5} \t NetPay: {6} \nGender: {7} \t PhoneNumber: {8} \t Department: {9} \t Address: {10}", employeeDataManager.EmployeeID, employeeDataManager.EmployeeName, employeeDataManager.BasicPay, employeeDataManager.Deduction, employeeDataManager.IncomeTax, employeeDataManager.TaxablePay, employeeDataManager.NetPay, employeeDataManager.Gender, employeeDataManager.EmployeePhoneNumber, employeeDataManager.EmployeeDepartment, employeeDataManager.Address);
                }
                //Close sqlDataReader Connection
                sqlDataReader.Close();
            }
            //Close Connection
            sqlConnection.Close();
        }
    }
}
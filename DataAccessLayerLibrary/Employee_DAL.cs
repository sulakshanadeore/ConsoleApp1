using BusinessLogicLayerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace DataAccessLayerLibrary
{
    public class Employee_DAL
    {
        /// <summary>
        /// Insert into employee table the data for firstname,lastname,title,birthdate
        /// Empid is identity field so not inserting
        /// </summary>
        /// <param name="employee"></param>
        public bool InsertEmployee(Employee_BAL employee)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into employees(lastname,firstname,title,birthdate) values(@lastname,@firstname,@title,@birthdate)", cn);
            cmdInsert.Parameters.AddWithValue("@lastname", employee.LastName);
            cmdInsert.Parameters.AddWithValue("@firstname", employee.FirstName);
            cmdInsert.Parameters.AddWithValue("@title", employee.Title);
            cmdInsert.Parameters.AddWithValue("@birthdate", employee.BirthDate);
            cn.Open();
            int i=cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i==1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;


        }


        public bool UpdateEmployee(Employee_BAL employee)
        {
            
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NorthCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].[sp_UpdateEmployee]", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_empid", employee.EmployeeID);
            cmdUpdate.Parameters.AddWithValue("@p_lname", employee.LastName);
            cmdUpdate.Parameters.AddWithValue("@p_fname", employee.FirstName);
            cmdUpdate.Parameters.AddWithValue("@p_title", employee.Title);
            cmdUpdate.Parameters.AddWithValue("@p_birthdate", employee.BirthDate);
            cn.Open();
            int i=cmdUpdate.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;

        }
        public void DeleteEmployee(Employee_BAL employee)
        { 
        
        }
        //public Employee_BAL FindEmployee(Employee_BAL employee)
        //{

        //}

        //public List<Employee_BAL> EmployeeList()
        //{ 
        
        //}

      
    }
}

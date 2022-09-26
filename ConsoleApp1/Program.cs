using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;
using BusinessLogicLayerLibrary;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("--------------------------------");
            Employee_Helper helper = new Employee_Helper();
            Console.WriteLine("Menu");
            Console.WriteLine("-----");
            Console.WriteLine("1. Add New Employee \n 2. Update Employee \n 3. Find Employee \n 4. Show All \n 5.Delete \n 6. Exit");
            int userchoice = Convert.ToInt32(Console.ReadLine());
            Employee_BAL emp = new Employee_BAL();
            switch (userchoice)
            {
                case 1:
                    
                    Console.WriteLine("Enter firstname");
                    emp.FirstName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter lastname");
                    emp.LastName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter title");
                    emp.Title = Console.ReadLine().Trim();
                    Console.WriteLine("Enter birthdate");
                    emp.BirthDate = Convert.ToDateTime(Console.ReadLine());

                   bool queryStatus= helper.AddEmployee(emp);
                    if (queryStatus)
                    {
                        Console.WriteLine("Employee added successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }
                    break;
                case 2:

                    Console.WriteLine("Enter Employeeid ");
                    emp.EmployeeID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter firstname");
                    emp.FirstName = Console.ReadLine().Trim();

                    Console.WriteLine("Enter lastname");
                    emp.LastName = Console.ReadLine().Trim();
                    Console.WriteLine("Enter title");
                    emp.Title = Console.ReadLine().Trim();
                    Console.WriteLine("Enter birthdate");
                    emp.BirthDate = Convert.ToDateTime(Console.ReadLine());

                     queryStatus = helper.EditEmployee(emp);
                    if (queryStatus)
                    {
                        Console.WriteLine("Employee updated successfully.....");
                    }
                    else
                    {
                        Console.WriteLine("Some error occured...");
                    }


                    break;
                case 3:
                    break;
                case 4:
                case 5:
                    break;
                case 6:
                    Environment.Exit(1);
                    break;
                
           
            }

            Console.ReadLine();
        }
    }
}

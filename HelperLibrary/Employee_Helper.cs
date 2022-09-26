using BusinessLogicLayerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerLibrary;
namespace HelperLibrary
{
    public class Employee_Helper
    {
        Employee_DAL dal = null;
        public Employee_Helper()
        {
            dal = new Employee_DAL();
        }
        

        public bool AddEmployee(Employee_BAL employee)
        {
            return dal.InsertEmployee(employee);

        }


        public bool EditEmployee(Employee_BAL employee)
        {
            return dal.UpdateEmployee(employee);
        }
        public void RemvoeEmployee(Employee_BAL employee)
        {

        }
        //public Employee_BAL SearchEmployee(Employee_BAL employee)
        //{

        //}

        //public List<Employee_BAL> ShowEmployeeList()
        //{

        //}
    }
}

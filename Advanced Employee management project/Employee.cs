using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Employee_management_project
{
    public class Employee
    {
        string employeeId;
        string employeeName;
        double employeePayRate;
        DateTime terminationDate;

        public Employee(string newId, string newName, double newPayRate)
        {
            employeeId = newId;
            employeeName = newName;
            employeePayRate = newPayRate;
        }

        public Employee()
        {
        }

        #region Properties
        public string EmployeeId
        {
            get
            {
                return employeeId;
            }
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;
            }
        }

        public double EmployeePayRate
        {
            get
            {
                return employeePayRate;
            }
        }

        public DateTime TerminationDate
        {
            get
            {
                return terminationDate;
            }
        }
        #endregion

        #region Methods
        public void TerminateEmp()
        {
            terminationDate = DateTime.Today;
        }

        public void GiveEmployeeRaise1()
        {
            employeePayRate = employeePayRate * 2;
        }
        #endregion
    }

}
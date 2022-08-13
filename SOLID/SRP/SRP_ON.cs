using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class SRP_ON
    {
        /*
         * Single Responsibility Principle:
         * In programming, the Single Responsibility Principle states that every module or class 
         * should have responsibility over a single part of the functionality provided by the software.
         * 
         * Each software module or class should have only one reason to change.
         */

        public class Employee
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public int Age { get; set; }

            public string Department { get; set; }

            public decimal Salary { get; set; }

            public DateTime StartDate { get; set; }
        }

        public class EmployeeManager
        {
            private List<Employee> employees;
            public void Register(Employee employee)
            {
                employees.Add(employee);
            }

            public List<Employee> GetEmployees()
            {
                return employees;
            }
        }
        public class Accounting
        {   
            public Employee CalculateSalary(Employee employee)
            {
                if ((DateTime.Now.Year - employee.StartDate.Year) >= 3)
                {
                    employee.Salary += employee.Salary * 1.4m;
                }

                return employee;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class SRP_OFF
    {
        public class Employee
        {
            private List<Employee> employees;   
            public string FirstName { get; set; }
            
            public string LastName { get; set; }

            public int Age { get; set; }

            public string Department { get; set; }

            public decimal Salary { get; set; }

            public DateTime StartDate { get; set; }

            public void Register(Employee employee)
            {
                employees.Add(employee);
            }

            public List<Employee> GetEmployees()
            {
                return employees;
            }

            public void CalculateSalary()
            {
                if((DateTime.Now.Year - StartDate.Year) >= 3 )
                {
                    Salary += Salary * 1.4m;
                }
            }


        }
    }
}

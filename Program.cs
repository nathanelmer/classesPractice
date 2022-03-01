using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company walmart = new Company()
            {
                Name = "Walmart",
                CreatedOn = "12/23/2003",
                EmployeeList = new List<Employee>()
            };

            // Create three employees
            Employee james = new Employee()
            {
                FirstName = "James",
                LastName = "Bond",
                Title = "Bagger"
            };
            Employee jury = new Employee()
            {
                FirstName = "Jury",
                LastName = "Byrd",
                Title = "Cashier"
            };
            Employee carter = new Employee()
            {
                FirstName = "Carter",
                LastName = "Broad",
                Title = "Bagger"
            };
            // Assign the employees to the company
            void AssignToCompany(Employee employee, Company company)
            {
                company.EmployeeList.Add(employee);
            }

            AssignToCompany(jury, walmart);
            AssignToCompany(james, walmart);
            AssignToCompany(carter, walmart);

            foreach (Employee emp in walmart.EmployeeList)
            {
                if (walmart.EmployeeList.Count > 0)
                {
                    Console.WriteLine($"{emp.FirstName} {emp.LastName} is a {emp.Title} at Walmart.");
                }
                else
                {
                    Console.WriteLine("Walmart has no employees!");
                }

            }

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}

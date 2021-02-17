using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TTAnu
{
    class Company
    {
        public List<Employee> Employees = new List<Employee>();

        public static Company operator +(Company employees, Employee employee)
        {
            if (employees.Employees.IsExist(employee) == -1)
            {
                employees.Employees.Add(employee);
                Console.WriteLine("-----------------------Added--------------------");
            }

            else
                Console.WriteLine("------------------Already exists---------------------");

            return employees;
        }

        public static Company operator -(Company employees, Employee employee)
        {
            int empIdx = employees.Employees.IsExist(employee);
            if (empIdx != -1)
            {
                employees.Employees.RemoveRange(empIdx, 1);
                Console.WriteLine("-----------------------Deleted--------------------");
            }

            else
                Console.WriteLine("------------------This employe did not found---------------------");

            return employees;
        }

        public IEnumerable<Employee> GetEmployeesByType(string type)
        {
            var emp = Employees.Where(x => x.ToString().Substring(x.ToString().IndexOf('.') + 1).ToLower()
                                           == type.ToLower());

            return emp;
        }

        public int GetQantEmployeesByType(string type)
        {
            return GetEmployeesByType(type).Count();
        }
    }
}

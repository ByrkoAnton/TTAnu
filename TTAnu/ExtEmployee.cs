using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace TTAnu
{
    static class ExtEmployee
    {
        public static int IsExist(this List<Employee> employees, Employee employee)
        {

            var index = employees.FindIndex(x => x.LastName == employee.LastName
                                                 && x.FirstName == employee.FirstName);

            return index;
        }

        public static void ShowAll(this List<Employee> employees)
        {
            foreach (var i in employees)
            {
                i.ShowEmployee();
            }
        }
    }
}

using System;
using System.Linq;

namespace TTAnu
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            var employee1 = new Worker("Anton", "Byrko", 10);
            var employee2 = new Worker("Ivan", "Ivanov", 5);
            var employee3 = new Manager("Pavel", "Pavlov", 8);
            var employee4 = new Taskmaster("Sergey", "Sergeev", 12);
            var employee5 = new Manager("Vova", "Sidorov", 15);

            company += employee1;
            company += employee2;
            company += employee3;
            company += employee4;
            company += employee4;
            company += employee5;

            company.Employees.ShowAll();

            Console.WriteLine("______________________________");

            var emp = company.GetEmployeesByType("worker").ToList();
            emp.ShowAll();

            Console.WriteLine("______________________________");

            Console.WriteLine(company.GetQantEmployeesByType("Taskmaster"));

            Console.WriteLine("______________________________");

            company -= employee1;
            company -= employee2;
            company -= employee3;
            company -= employee4;
            company -= employee4;
            company -= employee5;

            Console.WriteLine(company.Employees.Count);
        }
    }
}

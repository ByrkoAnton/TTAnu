using System;
using System.Collections.Generic;
using System.Text;

namespace TTAnu
{
    class Worker : Employee
    {
        public Worker(string firstName, string lastName, int experience) : base(firstName, lastName, experience)
        {
        }
        public override void Work()
        {
            Console.WriteLine("Worker - production of company products");
        }
    }
}

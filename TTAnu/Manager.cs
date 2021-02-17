using System;
using System.Collections.Generic;
using System.Text;

namespace TTAnu
{
    class Manager : Employee
    {
        public Manager(string firstName, string lastName, int experience) : base(firstName, lastName, experience)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Manager - order processing");
        }

        public void SetTask()
        {
            Console.WriteLine("Task set");
        }
    }
}

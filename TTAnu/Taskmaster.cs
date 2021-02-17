using System;
using System.Collections.Generic;
using System.Text;

namespace TTAnu
{
    class Taskmaster : Employee
    {
        public Taskmaster(string firstName, string lastName, int experience) : base(firstName, lastName, experience)
        {
        }

        public override void Work()
        {
            Console.WriteLine("Taskmaster - purchase of materials");
        }

        public void CheckingWorkers()
        {
            Console.WriteLine("Workers checked");
        }
    }
}

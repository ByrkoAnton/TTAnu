using System;
using System.Collections.Generic;
using System.Text;

namespace TTAnu
{
    abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Experience { get; set; }

        protected Employee(string firstName, string lastName, int experience)
        {
            FirstName = firstName;
            LastName = lastName;
            Experience = experience;
        }

        public abstract void Work();

        public void ShowEmployee()
        {
            string position = ToString();
            if (position != null)
            {
                position = position.Substring(position.IndexOf('.') + 1);
                Console.WriteLine($"{position}\n" +
                                  $"First name: {FirstName}\n" +
                                  $"Last Name: {LastName}\n" +
                                  $"Experience: {Experience}\n");
            }
        }
    }
}

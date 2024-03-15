using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Application
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public User(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}, Age: {Age}, changed version");
        }

    }
}

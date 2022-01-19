using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //  properties of class Person with data type string
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //  method that takes no parameters and writes the person's full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }
    }
}

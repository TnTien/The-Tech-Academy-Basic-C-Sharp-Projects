using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates and initializes Employee object
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
           
            //  calls the superclass method SayName() on the Employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}

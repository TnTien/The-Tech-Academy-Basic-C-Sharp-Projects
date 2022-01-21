using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates and initializes Employee class
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //  calls the SayName method
            employee.SayName();

            employee.Quit();

            //  instantiates IQuittable type object from Employee class
            IQuittable quit = new Employee();
            //  calls the Quit() method.
            quit.Quit();
            Console.ReadLine();
        }
    }
}

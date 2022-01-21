using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //  Employee class, inherited class from Person, inherited interface from IQuittable
    class Employee : Person, IQuittable
    {
        //  SayName is implemented here
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

        //  Quit method is impleted, print to console
        public void Quit()
        {
            Console.WriteLine("I quit");
        }
    }
}

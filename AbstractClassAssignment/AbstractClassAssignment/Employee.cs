using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //  Employee class, inherited class from Person
    class Employee : Person
    {
        //  SayName is implemented here
        public override void SayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
}

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
        public int ID { get; set; }

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

        //  == operator overloading, takes two Employee obect
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            //  compares ID of each object and compares, will return true or false
            return emp1.ID == emp2.ID;
        }
        //  != operator overloading is required if overloading operator ==
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.ID != emp2.ID;
        }
    }
}

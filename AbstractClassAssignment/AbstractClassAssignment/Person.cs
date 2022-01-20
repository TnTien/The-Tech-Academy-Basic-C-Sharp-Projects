using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    //  abstract Person class, this class can't be instantiated
    public abstract class Person
    {
        //  properties of the Person class
        public string firstName { get; set; }
        public string lastName { get; set; }
        //  abstract method of the Person class, classes that are inherited from Person is required to implement this method
        public abstract void SayName();
    }
}

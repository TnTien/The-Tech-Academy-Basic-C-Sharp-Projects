using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        public string Name;
        public string Address;
        public string Postcode;
        //  constructor with one parameter, this will inherit from the other constructor
        //  if only one argument is entered, the other parameters will be entered as string "Blank"
        public Person(string name) : this(name, "Blank", "Blank")
        {
        }
        //  constructor with three parameter
        public Person(string name, string address, string postcode)
        {
            Name = name;
            Address = address;
            Postcode = postcode;
        }
    }
}

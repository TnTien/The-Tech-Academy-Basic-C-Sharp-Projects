using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates class
            operations operations = new operations();

            //  calls method, passing 2 numbers
            operations.Add(10, 20);
            //  calls method, specifies parameters by name
            operations.Add(num2: 5, num: 2);
            
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates object to be able to call methods
            mathOperation mathoperation = new mathOperation();

            //  prints message on console
            Console.WriteLine("Choose a number for math operations.");
            //  converts user input and saves to int var
            int number = Convert.ToInt32(Console.ReadLine());

            //  displays the results of each method using the argument provided by the user input.
            Console.WriteLine("Half of " + number + " is " + mathoperation.Half(number) + ".");
            Console.WriteLine(mathoperation.Double(number) + " is double of " + number + ".");
            Console.WriteLine(mathoperation.Triple(number) + " is triple of " + number + ".");
            Console.ReadLine();
        }
    }
}

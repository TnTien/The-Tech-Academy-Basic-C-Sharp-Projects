using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates the class
            mathOperations mathOperations = new mathOperations();
            //  an int argument is entered and the first method will be called
            int half = mathOperations.Divide(24);
            Console.WriteLine(half);

            Console.WriteLine("What is your total bill?");
            //  Converts user input into a decimal
            decimal total = Convert.ToDecimal(Console.ReadLine());
            //  Because a decimal value is used for the argument, this will call the 2nd method
            decimal tipTotal = mathOperations.Divide(total);
            //  string.Format just formats the string to make sure only 2 digit is after the .
            Console.WriteLine("15% of ${0} is {1}", total, string.Format("{0:C}",tipTotal));

            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            //  Because a string is entered as an argument, this will call the 3rd method
            Console.WriteLine("{0} divided by 5 is {1}.", number, mathOperations.Divide(number));

            Console.ReadLine();
        }
    }
}

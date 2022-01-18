using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates the class
            mathOperations mathOperations = new mathOperations();

            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number. It is not necessary to enter a second number.");
            string num2 = Console.ReadLine();

            //  if user entered a number, this block will run
            if (num2.Length > 0)
            {
                int num2int = Convert.ToInt32(num2);
                Console.WriteLine("{0} multiplied by {1} is {2}.", num, num2, mathOperations.Multiply(num, num2int));
            }
            else
            {
                //  is user did not enter a second input, this block will run
                Console.WriteLine("{0} is the number you have entered.", mathOperations.Multiply(num));
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates class
            mathOperation math = new mathOperation();

            Console.WriteLine("Please enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());

            //  method does not return a value
            math.Divide(num);

            //  declares an int variable for the output
            int originalNum;
            //  method that has an output
            math.Count2(num, out originalNum);
            Console.WriteLine(originalNum);

            Console.WriteLine("Enter another number");
            string strNum = Console.ReadLine();

            //  because the argument entered is a string, this will use the 2nd method
            Console.WriteLine(math.Divide(strNum));
            //  prints out static class, does not need to be instantiated
            Console.WriteLine(Student.firstName + " " + Student.lastName);
            Console.ReadLine();
        }
    }
}

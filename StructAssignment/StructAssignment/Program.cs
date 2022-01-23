using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  instantiates object of Number
            Number number = new Number();
            //  assign amount to number
            number.Amount = 12.00M;

            //  prints to console
            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}

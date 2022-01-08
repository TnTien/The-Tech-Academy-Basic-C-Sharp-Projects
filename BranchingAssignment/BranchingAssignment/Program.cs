using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  prints message to console
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\nPlease enter the package weight: ");
            //  converts input to int and saves to int variable
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package width: ");
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package lenght: ");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            //  adds the dimensions
            int totalDimension = pkgHeight + pkgLength + pkgWidth;
            //  calculates the price
            int totalPrice = pkgHeight * pkgLength * pkgWidth * pkgWeight / 100;

            if (totalDimension <= 50)
            {
                //  if condition is true, will print this message to console
                Console.WriteLine("Your estimated total for shipping this package is: $" + totalPrice + ".00\nThank you!");
            }
            else
            {   //  if condition is false, will print this message to console
                Console.WriteLine("Package too big to be shipped via Package Express");
            }
            //  keeps console running until user exits
            Console.ReadLine();
        }
    }
}

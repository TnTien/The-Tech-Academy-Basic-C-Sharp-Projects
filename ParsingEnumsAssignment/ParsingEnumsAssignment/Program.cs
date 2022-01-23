using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //  Prints message on console asking for user input
                Console.WriteLine("What is the current day of the week?");
                //  Saves user input into a string variable
                string input = Console.ReadLine().ToLower();
 
                //  Converts string to enum
                Days inputDays = (Days)Enum.Parse(typeof(Days), input);
                
            }
            //  If user input isn't found in the enum Days, console will print this message
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();


        }
    }
}

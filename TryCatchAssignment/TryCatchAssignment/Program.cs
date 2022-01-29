using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Print message to console
            Console.WriteLine("How old are you?");
            //  Error Handling with Exceptions
            try
            {
                //  Converts user input to int and saves to variable
                int age = Convert.ToInt32(Console.ReadLine());
                //  Gets the current date time
                DateTime currentDate = DateTime.Now;
                //  Gets the current year and minus by the user age
                int year = currentDate.Year - age;
                //  If user enters 0 or negative number, an exception will be thrown
                if ( age <= 0)
                {
                    throw new InvalidNumberException();
                }
                //  Prints out what the current year minus age is equal to.
                Console.WriteLine($"You were born in year {year}");
                Console.ReadLine();

            }
            //  If user enters a 0 or a negative number
            catch (InvalidNumberException)
            {
                Console.WriteLine("Please enter a number greater than 0.");
                Console.ReadLine();
            }
            //  Any other error, if a user enter a string.. etc...
            catch (Exception)
            {
                Console.WriteLine("There is an error");
                Console.ReadLine();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  prints current date and time to the console
            Console.WriteLine(DateTime.Now);

            //  prints message to console asking user to enter a number
            Console.WriteLine("Please enter a number.");
            //  converts user input to int and save to int variable
            int number = Convert.ToInt32(Console.ReadLine());

            //  prints current date and time and add the int number to the hour in Date.Time
            Console.WriteLine(DateTime.Now.AddHours(number));

            Console.Read();
        }
    }
}

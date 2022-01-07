using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {   
            //  Prints message on console to enter hourly rate
            Console.WriteLine("Person 1: \nHourly Rate: ");
            //  Saves input into string variable
            string strRate1 = Console.ReadLine();
            //  Converts string var to int
            int p1Rate = Convert.ToInt32(strRate1);
            Console.WriteLine("Person 1: \nHours worked per week: ");
            string strHoursWorked1 = Console.ReadLine();
            int p1HoursWorked = Convert.ToInt32(strHoursWorked1);

            Console.WriteLine("Person 2: \nHourly Rate: ");
            string strRate2 = Console.ReadLine();
            int p2Rate = Convert.ToInt32(strRate2);
            Console.WriteLine("Person 2: \nHours worked per week: ");
            string strHoursWorked2 = Console.ReadLine();
            int p2HoursWorked = Convert.ToInt32(strHoursWorked2);

            //  Not an accurate number, basing it on hours worked per week and multiplying it by 4 weeks a month and then 12 months for a year
            int p1Annual = p1Rate * p1HoursWorked * 48;
            int p2Annual = p2Rate * p2HoursWorked * 48;

            //  Prints message with annual salary to console
            Console.WriteLine("Annual salary of Person 1: \n" + p1Annual);
            Console.WriteLine("Annual salary of Person 2: \n" + p2Annual);

            //  Will save boolean value if true or false
            bool p1greaterp2 = p1Annual > p2Annual;

            //  Converts bool into string and displays on console
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + Convert.ToString(p1greaterp2));
            Console.ReadLine();
        }
    }
}

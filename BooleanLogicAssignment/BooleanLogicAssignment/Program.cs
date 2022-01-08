using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Prints message to console
            Console.WriteLine("What is your age?");
            //  saves input to string variable
            string strAge = Console.ReadLine();
            //  converts string variable into int
            int age = Convert.ToInt32(strAge);

            Console.WriteLine("Have you ever had a DUI? (true or false)");
            //  saves input to string variable, only accepts true or false
            string strDUI = Console.ReadLine();
            //  converts string true or false to bool
            bool DUI = Convert.ToBoolean(strDUI);

            Console.WriteLine("How many speeding tickets do you have?");
            string strTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(strTickets);
            
            //  boolean logic
            if (age > 15 && DUI == false && tickets <= 3)
            {
                //  will print to console if conditions are met
                Console.WriteLine("Qualified?\n" + true);
            }
            else
            {
                //  otherwise will print this message if conditions are not met
                Console.WriteLine("Qualified?\n" + false);
            }
            //  keeps console open until exited
            Console.ReadLine();
        }
    }
}

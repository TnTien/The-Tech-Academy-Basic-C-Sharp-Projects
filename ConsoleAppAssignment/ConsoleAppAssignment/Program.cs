using System;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a whole number: ");
            //  Saves input into variable, input is a string
            string strNum = Console.ReadLine();
            //  Converts string variable to int
            int num = Convert.ToInt32(strNum);
            //  Multiplies var by 50 and saves in new variable
            int total = num * 50;
            //  Displays message on console
            Console.WriteLine(num + " * 50 = " + total);

            Console.WriteLine("Enter a whole number: ");
            string strNum2 = Console.ReadLine();
            int num2 = Convert.ToInt32(strNum2);
            int total2 = num2 + 25;
            Console.WriteLine(num2 + " + 25 = " + total2);

            Console.WriteLine("Enter a whole number: ");
            string strNum3 = Console.ReadLine();
            //  Adds string .0 to the string variable then converts to a double in order to divide with 12.5
            double num3 = Convert.ToDouble(strNum3 + ".0");
            double total3 = num3 / 12.5;
            Console.WriteLine(num3 + " / 12.5 = " + total3 + strNum3);

            Console.WriteLine("Enter a whole number: ");
            string strNum4 = Console.ReadLine();
            int num4 = Convert.ToInt32(strNum4);
            // Comparison operator, checks if user input is greater than 50
            bool greater50 = num4 > 50;
            //  Will display True if greater than 50 or False if less than 50
            Console.WriteLine(num4 + " is greater than 50. " + Convert.ToString(greater50));

            Console.WriteLine("Enter a whole number: ");
            string strNum5 = Console.ReadLine();
            int num5 = Convert.ToInt32(strNum5);
            //  Will save the remainder of user input number / 7
            int remainder = num5 % 7;
            Console.WriteLine(num5 + " / 7 has a remainder of: " + remainder);
            //  Leaves console on until user closes the console
            Console.ReadLine();
        }
    }
}

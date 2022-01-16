using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  List
            List<int> numbers = new List<int>();
            numbers.Add(12);
            numbers.Add(25);
            numbers.Add(9);
            numbers.Add(100);
            numbers.Add(27);

            //  Exception Handler, will try this block
            try
            {
                Console.WriteLine("Please enter a number");
                int userInput = Convert.ToInt32(Console.ReadLine());
                //  will go through each elemen of the List and perfom the action in the block
                foreach (int number in numbers)
                {
                    int divided = number / userInput;
                    Console.WriteLine(number + " divided by " + userInput + " equals " + divided);
                }
            }
            //  will display this error if user enters a string
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a whole number");
            }
            //  will display this error if user enters the number 0
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            //  this block will always perform after the try/catch block
            finally
            {
                Console.WriteLine("Program will now continue");
            }

            Console.ReadLine();
        }
    }
}

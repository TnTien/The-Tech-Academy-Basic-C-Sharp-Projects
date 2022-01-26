using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  prints message to console
            Console.WriteLine("What is your number?");
            //  saves user input into string variable
            string number = Console.ReadLine();
            //  this ensure that the code in the block gets disposed to free up memory, // will take a path and append or create a txt file
            using (StreamWriter file = new StreamWriter(@"D:\The-Tech-Academy-Basic-C-Sharp-Projects\InputAssignment\log.txt", true))
            {
                //  this will write the value of number
                file.WriteLine(number);
            }

            //  this will read all the text in the txt file and save it in the string variable
            string readText = File.ReadAllText(@"D:\The-Tech-Academy-Basic-C-Sharp-Projects\InputAssignment\log.txt");

            //  prints out value to console
            Console.WriteLine(readText);
            Console.Read();
        }
    }
}

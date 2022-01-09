using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDoWhileAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  int var set to 0
            int i = 0;
            //  while loop
            while (i < 6)
            {
                //  while i is less than 6, console will print this message
                Console.WriteLine("i = " + i);
                //  adds 1 to current value of i
                i++;
            }
            Console.ReadLine();

            int j = 0;
            //  this loop will run until condition is met, condition is checked after the body of do is executed
            do
            {
                Console.WriteLine("j = " + j);
                j++;
            }
            //  loop will run as long as j is not 10, if j starts as higher than 10 then this will become an infinite loop
            while (j != 10);
            Console.ReadLine();
        }

            
    }
}

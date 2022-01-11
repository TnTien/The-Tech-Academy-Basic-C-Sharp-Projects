using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //  string variable
            string strHello = "Hello";
            string strWorld = "World";
            string strGoodbye = "Goodbye!";

            //  concatenates str variable; toUpper makes string all uppercase
            string strConcatenate = strHello + strWorld + strGoodbye.ToUpper();

            //  stringbuilder represents a mutable string of characters
            StringBuilder sb = new StringBuilder();
            //  appends value of var to stringbuilder
            sb.Append(strConcatenate);
            sb.Append(strHello);

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

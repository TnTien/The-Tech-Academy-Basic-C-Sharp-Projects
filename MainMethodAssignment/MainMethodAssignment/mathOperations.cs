using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment
{
    class mathOperations
    {
        //  C# Method overloading exampls
        //  takes an int argument and return an int
        public int Divide(int num)
        {
            return num / 2;
        }

        //  takes a decimal argument and return a decimal
        public decimal Divide(decimal num)
        {
            return num * .15m;
        }

        //  takes in a string, string will be converted to an int if possible, int will be returned
        public int Divide(string num)
        {
            return Convert.ToInt32(num) / 5;
        }
    }
}

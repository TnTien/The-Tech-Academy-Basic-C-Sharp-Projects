using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    class mathOperation
    {
        //  does not return a value, will print to console
        public void Divide(int num)
        {
            int total = num / 2;
            Console.WriteLine(total);
        }

        //  method overload
        public int Divide(string num)
        {
            int total = Convert.ToInt32(num) / 2;
            return total;
        }

        //  method with output parameters
        public int Count2(int num, out int originalNum)
        {
            originalNum = num;
            int count = 0;
            for (int  i = 0; i < num; i++)
            {
                Console.WriteLine(count += 2);
            }
            return count;
        }


    }
}

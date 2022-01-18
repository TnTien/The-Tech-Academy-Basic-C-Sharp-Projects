using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class mathOperations
    {
        //  accepts 2 arguments, 2nd argument is not required, if not provided it will default to 1
        public int Multiply(int num, int num2 = 1)
        {
            return num * num2;
        }
    }
}

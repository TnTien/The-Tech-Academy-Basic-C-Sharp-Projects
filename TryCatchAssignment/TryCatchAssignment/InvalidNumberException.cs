using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    public class InvalidNumberException : Exception
    {
        public InvalidNumberException()
            : base() { }
        public InvalidNumberException(string message)
            : base(message) { }
    }
}

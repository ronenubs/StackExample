using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
    public class StackOverflowException : Exception
    {
        public StackOverflowException(string msg)
            :base(msg)
        {

        }
    }
}

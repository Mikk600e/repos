using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class ExeptionProgram
    {
        
    }
    public class MoreThanOneBudgetNameException : Exception
    {
        public MoreThanOneBudgetNameException (string message) : base(message)
        {
        }
    }
    public class LessThanOneBudgetNameException : Exception
    {
        public LessThanOneBudgetNameException(string message) : base(message)
        {
        }
    }
}

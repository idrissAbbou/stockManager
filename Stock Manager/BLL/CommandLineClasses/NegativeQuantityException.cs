using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.CommandLineClasses
{
    class NegativeQuantityException : Exception
    {
        public NegativeQuantityException() : base("Quantity can't be negative")
        {

        }
    }
}

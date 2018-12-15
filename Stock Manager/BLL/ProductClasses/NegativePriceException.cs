using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ProductClasses
{
    class NegativePriceException : Exception
    {
        public NegativePriceException() : base("price can't be negative")
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ProductClasses
{
    class NullOrEmptyNameException : Exception
    {
        public NullOrEmptyNameException() : base("product name can't be null or empty")
        {

        }
    }
}

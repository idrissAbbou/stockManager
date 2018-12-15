using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.ProductClasses
{
    class NullOrEmptyBarcodeException : Exception
    {
        public NullOrEmptyBarcodeException() : base("barecode can't be null or empty")
        {

        }
    }
}

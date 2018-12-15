using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.ProductClasses;

namespace BLL.CommandLineClasses
{
    public class CommandLine
    {
        private Product _product;

        public Product CommandProduct
        {
            get { return _product; }
            set { _product = value; }
        }
        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                    throw new NegativeQuantityException();
                _quantity = value;
            }
        }

    }
}

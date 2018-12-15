using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BLL.ProductClasses
{
    public class Product
    {
        #region Properties and fields
        private string _barCode;

        public string BarCode
        {
            get { return _barCode; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new NullOrEmptyBarcodeException();
                _barCode = value;
            }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new NullOrEmptyNameException();
                _name = value;
            }
        }
        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if (value < 0) 
                    throw new NegativePriceException();
                _price = value;
            }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private Image _image;

        public Image ProductImage
        {
            get { return _image; }
            set { _image = value; }
        }
        #endregion

        #region methods
        public Product()
        {

        }

        public Product(string barcode, string name, double price, string description)
        {
            BarCode = barcode;
            Name = name;
            Price = price;
            Description = description;
        }

        public Product(string barcode, string name, double price, string description, Image image)
            : this(barcode, name, price, description)
        {
            ProductImage = image;
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {4}", BarCode
                , Name, Price, Description);
        }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                return this.BarCode == ((Product)obj).BarCode;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.BarCode.GetHashCode();
        }
        #endregion



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsSortingApp
{
    internal class Product
    {
        public string Name { get; set; }

        private decimal _price;

        private int _quantity; 

        public bool IsPerishable { get; set; }

        public decimal Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Please enter price above 0");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public int Quantity
        {
            get
            {
                return _quantity;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Quantity cannot be 0 or below!");
                }
                else
                {
                    _quantity = value;
                }
            }
        }

    }
}
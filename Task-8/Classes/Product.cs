using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    internal class Product : IComparable<Product>
    {
        #region References & Attributes
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        #endregion

        #region Constructor
        public Product(int _id, string _name, decimal _price)
        {
            Id = _id;
            Name = _name;
            Price = _price;
        }
        public Product()
        {
        }
        #endregion

        #region Methods
        public int CompareTo(Product P1)
        {
            if (this.Price > P1.Price)
                return 1;
            else if (this.Price < P1.Price)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return ($"The product is {Name} and the price is {Price}") ;
        }
        #endregion
    }
}

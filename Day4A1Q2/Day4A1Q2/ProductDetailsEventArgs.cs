using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A1Q2
{
    class ProductDetailsEventArgs : EventArgs
    {
        public ProductDetailsEventArgs(int productId,int Price, bool isDefective)
        {
            this.ProductId = productId;
            this.Price = Price;
            this.isDefective = isDefective;
        }

        public int ProductId { get; set; }
        public int Price { get; set; }
        public bool isDefective { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4A1Q2
{
    public class Product
    {
        public int Id{ get; set;}
        public int Price { get; set; }
        public bool IsDefective { get; set; }

        public Product(int id, int price, bool isDefective)
        {
            this.Id = id;
            this.Price = price;
            this.IsDefective = isDefective;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !this.GetType().Equals(obj.GetType()))
                return false;
            else
            {
                Product product = (Product)obj;
                return product.Id == this.Id; 
            }
        }

        public override string ToString()
        {
            return $"Id  = {this.Id}, Price = {this.Price}, Defective = {this.IsDefective}";
        }

    }
}

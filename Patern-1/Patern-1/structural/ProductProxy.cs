using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class ProductProxy : product 
    {
        private product _product;

        public ProductProxy(string name, Money price)
     : base(name, price)
        {
            _product = new product(name, price);
        }

        public override void DecreasePrice(Money amount)
        {
            Console.WriteLine("Proxy: checking permissions");
            _product.DecreasePrice(amount);
        }
    }
}

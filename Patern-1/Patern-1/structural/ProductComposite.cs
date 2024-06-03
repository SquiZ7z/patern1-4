using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class ProductComposite : product
    {
        private List<product> _products = new List<product>();

        public ProductComposite(string name, Money price) : base(name, price) { }


        public void AddProduct(product product)
        {
            _products.Add(product);
        }

        public void RemoveProduct(product product)
        {
            _products.Remove(product);
        }

        public override void DecreasePrice(Money amount)
        {
            foreach (var p in _products)
            {
                p.DecreasePrice(amount);
            }
        }
    }
}

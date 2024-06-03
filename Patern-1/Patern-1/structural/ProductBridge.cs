using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public abstract class ProductBridge
    {
        protected product _product;

        public ProductBridge(product product)
        {
            _product = product;
        }

        public abstract void DecreasePrice(Money amount);
    }

    public class ConcreteProductBridge : ProductBridge
    {
        public ConcreteProductBridge(product product) : base(product) { }

        public override void DecreasePrice(Money amount)
        {
            _product.Price.WholePart -= amount.WholePart;
            _product.Price.FractionalPart -= amount.FractionalPart;
            if (_product.Price.FractionalPart < 0)
            {
                _product.Price.WholePart -= 1;
                _product.Price.FractionalPart += 100;
            }
        }
    }
}

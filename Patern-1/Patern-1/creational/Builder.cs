using Patern_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class Builder
    {

        private ProductBuilder _product;

        public Builder()
        {
            _product = new ProductBuilder();
        }

        public Builder WithName(string name)
        {
            _product.Name = name;
            return this;
        }

        public Builder WithPrice(Money price)
        {
            _product.Price = price;
            return this;
        }

        public ProductBuilder Build()
        {
            return _product;
        }
    }

    public class ProductBuilder
    {
        public string Name { get; set; }
        public Money Price { get; set; }
    }
}

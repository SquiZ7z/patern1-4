using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class ProductFlyweight
    {
        private string _name;
        private Money _price;

        public ProductFlyweight(string name, Money price)
        {
            _name = name;
            _price = price;
        }

        public string GetName()
        {
            return _name;
        }

        public Money GetPrice()
        {
            return _price;
        }
    }

    public class ProductWrapper : product
    {
        private ProductFlyweight _flyweight;

        public ProductWrapper(ProductFlyweight flyweight)
            : base(flyweight.GetName(), flyweight.GetPrice())
        {
            _flyweight = flyweight;
        }

        public override string Name
        {
            get { return _flyweight.GetName(); }
        }

        public override Money Price
        {
            get { return _flyweight.GetPrice(); }
        }
    }
}

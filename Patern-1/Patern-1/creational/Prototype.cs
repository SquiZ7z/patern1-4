using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class Prototype
    {
        public Product Clone(Product product)
        {
            return (Product)product.Clone();
        }
    }

    public class Product : ICloneable
    {
        public string Name { get; set; }
        public Money Price { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    
}

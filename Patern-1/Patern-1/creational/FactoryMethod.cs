using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public abstract class FactoryMethod
    {
        public abstract AbstractProduct CreateProduct();
    }

    public class ConcreteFactoryA : FactoryMethod
    {
        public override AbstractProduct CreateProduct()
        {
            return new ProductA();
        }
    }

    public class ConcreteFactoryB : FactoryMethod
    {
        public override AbstractProduct CreateProduct()
        {
            return new ProductB();
        }
    }

    public abstract class AbstractProduct
    {
        public abstract void DoSomething();
    }

    public class ProductA : AbstractProduct
    {
        public override void DoSomething()
        {
            Console.WriteLine("Product A does something");
        }
    }

    public class ProductB : AbstractProduct
    {
        public override void DoSomething()
        {
            Console.WriteLine("Product B does something");
        }
    }
}

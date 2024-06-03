using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public abstract class AbstractFactory
    {
        public abstract product CreateProduct(string name, Money price);
        public abstract Warehouse CreateWarehouse(string name, string unit, Money unitPrice, int quantity, DateTime lastDeliveryDate);
    }

    public class ConcreteFactoryAImpl : AbstractFactory
    {
        public override product CreateProduct(string name, Money price)
        {
            return new productA(name, price);
        }

        public override Warehouse CreateWarehouse(string name, string unit, Money unitPrice, int quantity, DateTime lastDeliveryDate)
        {
            return new WarehouseA(name, unit, unitPrice, quantity, lastDeliveryDate);
        }
    }

    public class ConcreteFactoryBImpl : AbstractFactory
    {
        public override product CreateProduct(string name, Money price)
        {
            return new productB(name, price);
        }

        public override Warehouse CreateWarehouse(string name, string unit, Money unitPrice, int quantity, DateTime lastDeliveryDate)
        {
            return new WarehouseB(name, unit, unitPrice, quantity, lastDeliveryDate);
        }
    }

    public class productA : product
    {
        public productA(string name, Money price) : base(name, price) { }
    }

    public class productB : product
    {
        public productB(string name, Money price) : base(name, price) { }
    }

    public class WarehouseA : Warehouse
    {
        public WarehouseA(string name, string unit, Money unitPrice, int quantity, DateTime lastDeliveryDate)
            : base(name, unit, unitPrice, quantity, lastDeliveryDate) { }
    }

    public class WarehouseB : Warehouse
    {
        public WarehouseB(string name, string unit, Money unitPrice, int quantity, DateTime lastDeliveryDate)
            : base(name, unit, unitPrice, quantity, lastDeliveryDate) { }
    }
}

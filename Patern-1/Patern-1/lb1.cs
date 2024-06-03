using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Patern_1
{
    public class Money
    {
        public int WholePart { get; set; }
        public int FractionalPart { get; set; }
        public Money(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }
        public override string ToString()
        {
            return $"{WholePart}.{FractionalPart}";
        }
        public void SetValue(int wholePart, int fractionalPart)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
        }



    }
    public class product
    {

        public virtual string Name { get; set; }
        public virtual Money Price { get; set; }
        public product(string name, Money price)
        {
            Name = name;
            Price = price;
        }
        public virtual void DecreasePrice(Money amount)
        {
            int wholePart = Price.WholePart - amount.WholePart;
            int fractionalPart = Price.FractionalPart - amount.FractionalPart;
            if (fractionalPart < 0)
            {
                wholePart -= 1;
                fractionalPart += 100;
            }
            Price = new Money(wholePart, fractionalPart);

        }


    }
    public class Warehouse
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public Money UnitPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }
        public Warehouse(string name, string unit, Money unitPrice, int quantity, DateTime lastDeliveryDate)
        {
            Name = name;
            Unit = unit;
            UnitPrice = unitPrice;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
        }

    }
    public class Reporting
    {
        public void RegisterIncome(product product, int quantity, DateTime date)
        {
            Console.WriteLine($"Income report: {product.Name} x {quantity} on {date}");
        }

        public void RegisterOutcome(product product, int quantity, DateTime date)
        {
            Console.WriteLine($"Outcome report: {product.Name} x {quantity} on {date}");
        }

        public void InventoryReport(Warehouse warehouse)
        {
            Console.WriteLine($"Inventory report: {warehouse.Name} - {warehouse.Quantity} {warehouse.Unit} on {warehouse.LastDeliveryDate}");
        }

    }
}

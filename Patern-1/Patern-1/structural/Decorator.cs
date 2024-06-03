using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Patern_1
{
    public class Decorator : product
    {
        
        private product _product;

        public Decorator(string name, Money price, product product)
            : base(name, price)
        {
            _product = product;
        }

        public override void DecreasePrice(Money amount)
        {
            _product.DecreasePrice(amount);
            Console.WriteLine("Additional behavior: logging price change");
        }
    }

    public class moneyDecorator
    {
        private int _amount;
        private int _cents;

        public moneyDecorator(int amount, int cents)
        {
            _amount = amount;
            _cents = cents;
        }
    }
    
}

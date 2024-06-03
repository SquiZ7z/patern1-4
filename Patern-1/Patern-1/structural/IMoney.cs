using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public interface IMoney
    {
        decimal GetValue();
    }

    public class MoneyAdapter : IMoney
    {
        private Money _money;

        public MoneyAdapter(Money money)
        {
            _money = money;
        }

        public decimal GetValue()
        {
            return _money.WholePart + _money.FractionalPart / 100m;
        }
    }
}

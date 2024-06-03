using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class WarehouseFacade
    {
        private Dictionary<product, int> _inventory = new Dictionary<product, int>();

        public void RegisterIncome(product product, int quantity, DateTime date)
        {
            if (_inventory.ContainsKey(product))
            {
                _inventory[product] += quantity;
            }
            else
            {
                _inventory.Add(product, quantity);
            }
        }

        public void RegisterOutcome(product product, int quantity, DateTime date)
        {
            if (_inventory.ContainsKey(product) && _inventory[product] >= quantity)
            {
                _inventory[product] -= quantity;
            }
            else
            {
                throw new InvalidOperationException("Not enough items in inventory");
            }
        }

        public void InventoryReport()
        {
            Console.WriteLine("Inventory report:");
            foreach (var item in _inventory)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}

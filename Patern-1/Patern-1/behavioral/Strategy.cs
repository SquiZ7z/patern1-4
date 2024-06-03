using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    
        public interface IStrategy
        {
            void Execute();
        }

        public class ConcreteStrategyA : IStrategy
        {
            public void Execute()
            {
                Console.WriteLine("Strategy A executing");
            }
        }

        public class ConcreteStrategyB : IStrategy
        {
            public void Execute()
            {
                Console.WriteLine("Strategy B executing");
            }
        }

        public class ContextStrategy
    {
            private IStrategy strategy;

            public ContextStrategy(IStrategy strategy)
            {
                this.strategy = strategy;
            }

            public void ExecuteStrategy()
            {
                strategy.Execute();
            }
        }
    
}

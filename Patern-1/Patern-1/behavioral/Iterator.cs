using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class Iterator
    {
        public interface IIterator
        {
            bool HasNext();
            object Next();
        }

        public class ConcreteIterator : IIterator
        {
            private List<object> collection;
            private int index;

            public ConcreteIterator(List<object> collection)
            {
                this.collection = collection;
                this.index = 0;
            }

            public bool HasNext()
            {
                return index < collection.Count;
            }

            public object Next()
            {
                return collection[index++];
            }
        }

        
    }
}

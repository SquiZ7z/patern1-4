using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{ 
        public interface IVisitor
        {
            void Visit(Element element);
        }

        public class ConcreteVisitor : IVisitor
        {
            public void Visit(Element element)
            {
                Console.WriteLine("Visiting " + element.Name);
            }
        }

        public abstract class Element
        {
            public string Name { get; set; }

            public abstract void Accept(IVisitor visitor);
        }

        public class ConcreteElementA : Element
        {
            public override void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        public class ConcreteElementB : Element
        {
            public override void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }

        
    
}

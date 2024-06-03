using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public abstract class AbstractClass
    {
       
            public void TemplateMethod()
            {
                Step1();
                Step2();
                Step3();
            }

            protected abstract void Step1();
            protected abstract void Step2();
            protected abstract void Step3();
        }

        public class ConcreteClassA : AbstractClass
        {
            protected override void Step1()
            {
                Console.WriteLine("ConcreteClassA Step1");
            }

            protected override void Step2()
            {
                Console.WriteLine("ConcreteClassA Step2");
            }

            protected override void Step3()
            {
                Console.WriteLine("ConcreteClassA Step3");
            }
        }

        public class ConcreteClassB : AbstractClass
        {
            protected override void Step1()
            {
                Console.WriteLine("ConcreteClassB Step1");
            }

            protected override void Step2()
            {
                Console.WriteLine("ConcreteClassB Step2");
            }

            protected override void Step3()
            {
                Console.WriteLine("ConcreteClassB Step3");
            }
        }

        
        
    
}

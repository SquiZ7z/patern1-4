using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public interface IMediator
    {
        void Send(string message, Colleague colleague);
    }

    public interface Colleague
    {
        void Receive(string message);
    }

    public class ConcreteMediator : IMediator
    {
        private Colleague1 colleague1;
        private Colleague2 colleague2;

        public ConcreteMediator(Colleague1 colleague1, Colleague2 colleague2)
        {
            this.colleague1 = colleague1;
            this.colleague2 = colleague2;
        }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
            {
                colleague2.Receive(message);
            }
            else
            {
                colleague1.Receive(message);
            }
        }
    }

    public class Colleague1 : Colleague
    {
        public void Receive(string message)
        {
            Console.WriteLine("Colleague1 received: " + message);
        }
    }

    public class Colleague2 : Colleague
    {
        public void Receive(string message)
        {
            Console.WriteLine("Colleague2 received: " + message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public abstract class Handler
    {
        protected Handler next;

        public void SetNext(Handler next)
        {
            this.next = next;
        }

        public abstract void HandleRequest(Request request);
    }

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == "A")
            {
                Console.WriteLine("Handler A handling request");
            }
            else
            {
                next.HandleRequest(request);
            }
        }
    }

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == "B")
            {
                Console.WriteLine("Handler B handling request");
            }
            else
            {
                next.HandleRequest(request);
            }
        }
    }


    public class ConcreteHandlerC : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == "C")
            {
                Console.WriteLine("Handler C handling request");
            }
            else
            {
                next.HandleRequest(request);
            }
        }
    }
    public class Request
    {
        public string Type { get; set; }
    }
}

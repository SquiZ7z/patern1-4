using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public interface IObserver
    {
       
            void Update(string message);
        }

        public class ConcreteObserver : IObserver
        {
            public void Update(string message)
            {
                Console.WriteLine("Received: " + message);
            }
        }

        public class Subject
        {
            private List<IObserver> observers;

            public Subject()
            {
                observers = new List<IObserver>();
            }

            public void RegisterObserver(IObserver observer)
            {
                observers.Add(observer);
            }

            public void NotifyObservers(string message)
            {
                foreach (var observer in observers)
                {
                    observer.Update(message);
                }
            }
        }
    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    public class Originator
    {
        public string State { get; set; }

        public Memento CreateMemento()
        {
            return new Memento(State);
        }

        public void RestoreMemento(Memento memento)
        {
            State = memento.State;
        }
    }

    public class Memento
    {
        public string State { get; set; }

        public Memento(string state)
        {
            State = state;
        }
    }

    public class CareTaker
    {
        public Memento Memento { get; set; }

        public void SaveMemento(Originator originator)
        {
            Memento = originator.CreateMemento();
        }

        public void RestoreMemento(Originator originator)
        {
            originator.RestoreMemento(Memento);
        }
    }


}

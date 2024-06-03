using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patern_1
{
    internal class Command
    {
        public interface ICommand
        {
            void Execute();
            void Undo();
        }

        public class ConcreteCommand : ICommand
        {
            private Receiver receiver;
            private string state;

            public ConcreteCommand(Receiver receiver)
            {
                this.receiver = receiver;
            }

            public void Execute()
            {
                state = receiver.State;
                receiver.Action();
            }

            public void Undo()
            {
                receiver.State = state;
            }
        }

        public class Receiver
        {
            public string State { get; set; }

            public void Action()
            {
                Console.WriteLine("Receiver action");
                State = "New state";
            }
        }

        public class Invoker
        {
            private ICommand command;

            public void SetCommand(ICommand command)
            {
                this.command = command;
            }

            public void ExecuteCommand()
            {
                command.Execute();
            }

            public void UndoCommand()
            {
                command.Undo();
            }
        }

        
    }
}

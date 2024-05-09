using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask05_06
{
    class HtmlProcessorWithCommands
    {
        private readonly List<AddClassCommand> _commands = new List<AddClassCommand>();

        public void AddClass(string element, string classToAdd)
        {
            AddClassCommand command = new AddClassCommand(element, classToAdd);
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void UndoCommands()
        {
            for (int i = _commands.Count - 1; i >= 0; i--)
            {
                _commands[i].Undo();
            }
        }
    }
}
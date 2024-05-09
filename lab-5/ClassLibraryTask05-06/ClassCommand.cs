using System;
using System.Collections.Generic;
namespace ClassLibraryTask05_06
{
    class AddClassCommand
    {
        private readonly string _element;
        private readonly string _classToAdd;

        public AddClassCommand(string element, string classToAdd)
        {
            _element = element;
            _classToAdd = classToAdd;
        }

        public void Execute()
        {
            Console.WriteLine($"Adding class {_classToAdd} to element {_element}");
        }

        public void Undo()
        {
            Console.WriteLine($"Undoing adding class {_classToAdd} to element {_element}");
        }
    }
}

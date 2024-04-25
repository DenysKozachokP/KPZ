using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask5
{
    public class TextEditor
    {
        private TextDocument _currentDocument;
        private readonly Stack<TextDocument> _history;

        public TextEditor(string initialContent)
        {
            _currentDocument = new TextDocument(initialContent);
            _history = new Stack<TextDocument>();
            Save();
        }

        public void Save()
        {
            _history.Push(new TextDocument(_currentDocument.Content));
        }

        public void Undo()
        {
            if (_history.Count > 1)
            {
                _history.Pop();
                _currentDocument = new TextDocument(_history.Peek().Content);
            }
            else
            {
                Console.WriteLine("Неможливо скасувати дію. Історія змін порожня.");
            }
        }

        public void Display()
        {
            Console.WriteLine("Зміст документа:");
            Console.WriteLine("┌────────────────────────────:");
            Console.WriteLine($"|{ _currentDocument.Content}");
            Console.WriteLine("└────────────────────────────:");
        }

        public void Edit(string newContent)
        {
            _currentDocument.Content = newContent;
            Save();
        }
    }
}

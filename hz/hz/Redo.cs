using System;
using System.Collections.Generic;
using System.Text;

namespace hz
{
    public class Redo
    {
        private Stack<Figyru> figureStack;
        public Redo()
        {
            figureStack = new Stack<Figyru>();
        }

        public void Push(Figyru figyru)
        {
            figureStack.Push(figyru);
        }

        public Figyru Pop()
        {
            return figureStack.Pop();
        }

        public void CleanStack()
        {
            figureStack.Clear();
        }

        public bool IsEmpty()
        {
            if (figureStack.Count == 0)
                return false;

            return true;
        }
    }
}

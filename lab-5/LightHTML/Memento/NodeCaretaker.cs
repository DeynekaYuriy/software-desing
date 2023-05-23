using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.LightHTML.Memento
{
    public class NodeCaretaker
    {
        private Stack<INodeMemento> _mementos = new Stack<INodeMemento>();
        private LightNode _originator;
        public NodeCaretaker(LightNode originator)
        {
            _originator = originator;
        }
        public void Backup()
        {
            _mementos.Push(_originator.Save());
        }
        public void Undo()
        {
            if (_mementos.Count == 0)
                return;

            var memento = _mementos.Pop();
            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }
        public void ShowHistory()
        {
            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}

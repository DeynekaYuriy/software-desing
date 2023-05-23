using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.LightHTML.Memento
{
    public class TextNodeMemento : INodeMemento
    {
        private LightTextNode _state;
        private DateTime _date;
        public TextNodeMemento(LightTextNode state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public string GetName()
        {
            return $"{_date} | {_state.Tag}";
        }

        public LightNode GetState()
        {
            return _state;
        }
    }
}

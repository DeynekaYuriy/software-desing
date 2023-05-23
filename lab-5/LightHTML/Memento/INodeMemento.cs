using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.LightHTML.Memento
{
    public interface INodeMemento
    {
        string GetName();
        LightNode GetState();
        DateTime GetDate();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.LightHTML.Visitor
{
    public interface INodeVisitor
    {
        public void Visit(LightElementNode node);
        public void Visit(LightTextNode node);
    }
}

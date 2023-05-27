using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.LightHTML.Visitor
{
    public class MarkupAnalyzer : INodeVisitor
    {
        public int TextNodesCount { get; private set; }
        public int ElementNodesCount { get; private set; }
        public void Visit(LightElementNode node)
        {
            ElementNodesCount++;
            node.GetChildren().ForEach((node) =>
            {
                node.Accept(this);
            });
        }

        public void Visit(LightTextNode node)
        {
            TextNodesCount++;
        }
    }
}

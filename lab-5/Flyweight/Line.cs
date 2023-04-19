using lab_5.LightHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.Flyweight
{
    public class Line
    {
        public int LineIndex { get; }
        public string Text { get; }
        public LightNode Node { get; }
        public Line(string text, int lineIndex)
        {
            Text = text;
            LineIndex = lineIndex;
            Node = NodeFactory.GetNode(Text, LineIndex);
        }
    }
}

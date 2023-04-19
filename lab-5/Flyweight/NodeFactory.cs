using lab_5.LightHTML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.Flyweight
{
    public static class NodeFactory
    {
        private static List<LightNode> cache = new List<LightNode>()
        {
            new LightTextNode("h1"),
            new LightTextNode("h2"),
            new LightTextNode("blockquote"),
            new LightTextNode("p")
        };
        public static LightNode GetNode(string text, int lineIndex)
        {
            if (lineIndex == 0)
            {
                return cache[0];
            }
            if (text.Length < 20)
            {
                return cache[1];
            }
            if (text[0] == ' ')
            {
                return cache[2];
            }
            return cache[3];
        }
    }
}

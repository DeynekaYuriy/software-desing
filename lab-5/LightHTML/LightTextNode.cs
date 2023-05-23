using lab_5.LightHTML.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab_5.LightHTML
{
    public class LightTextNode : LightNode
    {
        public string? Text { get; set; }
        public LightTextNode(string tag, string text)
        {
            Tag = tag;
            Text = text;
        }
        public LightTextNode(string tag)
        {
            Tag = tag;
        }

        public override string InnerHTML()
        {
            return Text;
        }

        public override string OuterHTML()

        {
            return $"<{Tag}>{Text}</{Tag}>";
        }

        public override LightTextNode Clone()
        {
            return new LightTextNode(Tag, Text);
        }

        public override INodeMemento Save()
        {
            return new TextNodeMemento(Clone());
        }

        public override void Restore(INodeMemento memento)
        {
            if (memento is LightTextNode)
            {
                var node = (LightTextNode)memento.GetState();
                Tag = node.Tag;
                Text = node.Text;
            }
            else
            {
                throw new Exception("Unknown memento class");
            }
        }
    }
}

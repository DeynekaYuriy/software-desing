using lab_5.LightHTML.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab_5.LightHTML
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> children = new List<LightNode>();
        public NodeType NodeType { get; set; }
        public ClosureType ClosureType { get; set; }
        public List<string> CssClasses { get; set; }
        public int ChildCount => 0;
        public LightElementNode(string tag, NodeType nodeType, ClosureType closureType, List<string> cssClasses)
        {
            Tag = tag;
            NodeType = nodeType;
            ClosureType = closureType;
            CssClasses = cssClasses;
        }
        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder($"<{Tag} ");
            sb.Append($"classes=\"");
            foreach (var c in CssClasses)
            {
                sb.Append($"{c} ");
            }
            sb.Append("\"");
            if (ClosureType == ClosureType.Single)
            {
                sb.Append("/>");
            }
            else
            {

                sb.AppendLine(">");
                sb.AppendLine(InnerHTML());
                sb.Append($"</{Tag}>");

            }
            return sb.ToString();
        }
        public override string InnerHTML()
        {

            StringBuilder sb = new StringBuilder();

            foreach (var c in children)
            {
                sb.AppendLine($"\t{c.OuterHTML()}");
            }
            return sb.ToString();
        }
        public void AppendChild(LightNode node)
        {
            children.Add(node);
        }
        public void ReplaceChild(LightNode oldNode, LightNode newNode)
        {
            var index = children.IndexOf(oldNode);
            if (index != -1)
            {
                children[index] = newNode;
            }
        }
        public void RemoveChild(LightNode node)
        {
            var index = children.IndexOf(node);
            if (index != -1)
            {
                children.RemoveAt(index);
            }
        }
        public void InsertBefore(LightNode node, LightNode newNode)
        {
            var index = children.IndexOf(node);
            if (index != -1)
            {
                children.Insert(index, newNode);
            }
        }
        public override LightElementNode Clone()
        {
            var clone = new LightElementNode(Tag, NodeType, ClosureType, new(CssClasses));
            foreach (var c in children)
            {
                clone.children.Add(c.Clone());
            }
            return clone;
        }
        public override INodeMemento Save()
        {
            return new ElementNodeMemento(Clone());
        }

        public override void Restore(INodeMemento memento)
        {
            if (memento is ElementNodeMemento)
            {
                var node = (LightElementNode)memento.GetState();
                Tag = node.Tag;
                children = node.children;
                NodeType = node.NodeType;
                ClosureType = node.ClosureType;
                CssClasses = node.CssClasses;
            }
            else
            {
                throw new Exception("Unknown memento class");
            }
        }
    }
}

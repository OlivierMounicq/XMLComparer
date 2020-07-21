using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XMLComparerCore
{
    public class XmlDocNode
    {
        public string FullPath { get; }
        public string Path {get;}
        public string Name { get; }
        public IEnumerable<(string AttributeName, string AttributeValue)> Attributes { get; }

        public XmlDocNode(XmlDocNode innerNode)
        {
            FullPath = innerNode.FullPath;
            Path = innerNode.Path;
            Name = innerNode.Name;
            Attributes = innerNode.Attributes;
        }

        public XmlDocNode(XmlNode xmlNode)
        {
            var parents = GetAncestor(xmlNode);
            FullPath = parents.Select(r => r.Name).Aggregate((s, acc) => acc + "/" + s);
            Path = parents.Skip(1).Select(r => r.Name).Aggregate((s,acc) => acc + "/" + s);
            Name = xmlNode.Name;
            Attributes = GetAttributes(xmlNode).ToList();
        }

        private IEnumerable<XmlNode> GetAncestor(XmlNode xmlNode)
        {
            yield return xmlNode;

            if (xmlNode.ParentNode != null)
                foreach(var parent in GetAncestor(xmlNode.ParentNode))
                    yield return parent;
        }

        private IEnumerable<(string AttributeName, string AttributeValue)> GetAttributes(XmlNode xmlNode)
        {
            foreach (var attr in xmlNode.Attributes)
                yield return (AttributeName: ((XmlAttribute)attr).Name, AttributeValue: ((XmlAttribute)attr).Value);
        }
    }
}
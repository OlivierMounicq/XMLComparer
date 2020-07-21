using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace XMLComparerCore
{
    public class XmlDoc : XmlDocument
    {
        public XmlDoc(string xmlPath)
        {
            this.Load(xmlPath);
        }

        public IEnumerable<XmlDocNode> GetXmlData()
        {
            var childrenList = GetAllChildren(this.DocumentElement).ToList();
            var xmlDocNodeList = childrenList.Select(r => new XmlDocNode(r)).ToList();
            return xmlDocNodeList;                
        }

        private IEnumerable<XmlNode> GetAllChildren(XmlNode rootNode)
        {
            if (rootNode.Attributes != null && rootNode.Attributes.Count > 0)
                yield return rootNode;

            if (rootNode.HasChildNodes)
            {
                foreach(var childNode in rootNode.ChildNodes)
                {
                    foreach (var child in GetAllChildren(childNode as XmlNode))
                        yield return child;
                }
            }
        }
    }
}
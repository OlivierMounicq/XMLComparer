using System.Linq;

namespace XMLComparerCore.TypedNodes
{
    public class CsProjGeneric : XmlDocNode, ITypedNode
    {
        public string MainAttributeName {get { return "key"; } }
        public string MainAttributeValue {get;}
        
        public CsProjGeneric(XmlDocNode nestedXmlDocNode)
            :base(nestedXmlDocNode)
        { 
            MainAttributeValue = nestedXmlDocNode.Attributes.FirstOrDefault(r => r.AttributeName == MainAttributeName).AttributeValue;
        }
    }
}
using System.Linq;

namespace XMLComparerCore.TypedNodes
{
    public class CsProjConnectionAdd : XmlDocNode, ITypedNode
    {
        public string MainAttributeName {get { return "name"; } }
        public string MainAttributeValue {get;}
        
        public CsProjConnectionAdd(XmlDocNode nestedXmlDocNode)
            :base(nestedXmlDocNode)
        { 
            MainAttributeValue = nestedXmlDocNode.Attributes.FirstOrDefault(r => r.AttributeName == MainAttributeName).AttributeValue;
        }
    }
}
using System.Linq;

namespace XMLComparerCore.TypedNodes
{
    public class CsProjSectionGroup : XmlDocNode, ITypedNode
    {
        public string MainAttributeName {get { return "name"; } }
        public string MainAttributeValue {get;}
        
        public CsProjSectionGroup(XmlDocNode nestedXmlDocNode)
            :base(nestedXmlDocNode)
        { 
            MainAttributeValue = nestedXmlDocNode.Attributes.FirstOrDefault(r => r.AttributeName == MainAttributeName).AttributeValue;
        }
    }
}
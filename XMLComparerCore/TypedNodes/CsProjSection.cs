using System.Linq;

namespace XMLComparerCore.TypedNodes
{
    public class CsProjSection : XmlDocNode, ITypedNode
    {
        public string MainAttributeName {get { return "name"; } }
        public string MainAttributeValue {get;}
        
        public CsProjSection(XmlDocNode nestedXmlDocNode)
            :base(nestedXmlDocNode)
        { 
            MainAttributeValue = nestedXmlDocNode.Attributes.FirstOrDefault(r => r.AttributeName == MainAttributeName).AttributeValue;
        }
    }
}
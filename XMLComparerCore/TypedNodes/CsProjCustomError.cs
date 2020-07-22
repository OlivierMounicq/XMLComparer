using System.Linq;

namespace XMLComparerCore.TypedNodes
{
    public class CsProjCustomError : XmlDocNode, ITypedNode
    {
        public string MainAttributeName {get { return "mode"; } }
        public string MainAttributeValue {get;}
        
        public CsProjCustomError(XmlDocNode nestedXmlDocNode)
            :base(nestedXmlDocNode)
        { 
            MainAttributeValue = nestedXmlDocNode.Attributes.FirstOrDefault(r => r.AttributeName == MainAttributeName).AttributeValue;
        }
    }
}
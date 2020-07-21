namespace XMLComparerCore
{
    public class XmlDocNodeDoublet
    {
        public XmlDocNode LeftNode {get;}
        public XmlDocNode RightNode {get;}

        public XmlDocNodeDoublet(XmlDocNode leftNode, XmlDocNode rightNode)
        {
            LeftNode = leftNode;
            RightNode = rightNode;
        }
    }
}
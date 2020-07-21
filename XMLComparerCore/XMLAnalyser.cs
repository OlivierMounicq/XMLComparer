using System;
using System.Linq;
using System.Xml;

namespace XMLComparerCore
{
    public class XMLAnalyser
    {

        public static void Foo()
        {
            var leftXmlPath = @"C:\Date\2020.07.21\Web.config";
            var leftXmlDoc = new XmlDoc(leftXmlPath);
            var leftNodeList = leftXmlDoc.GetXmlData().ToList();

            var rightXmlPath = @"C:\Date\2020.07.21\Web.config";
            var rightXmlDoc = new XmlDoc(rightXmlPath);
            var rightNodeList = rightXmlDoc.GetXmlData().ToList();


            foreach(var node in leftNodeList)
            {
                






            }



            



        }




    }
}
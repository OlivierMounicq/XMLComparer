using System;
using System.Linq;
using System.Xml;

namespace XMLComparerCore
{
    public class XMLAnalyser
    {

        public static void Foo()
        {
            var xmlPath = @"C:\Date\2020.07.21\Web.config";
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(xmlPath);

        }




    }
}
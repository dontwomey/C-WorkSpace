using System;
using System.Xml;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Text;
using System.Data;

namespace XMLReader
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load("breakfast_menu.xml");

            XmlNodeList elemlist = doc.GetElementsByTagName("name");
         
            foreach (XmlNode node in elemlist)
            {
                if (node.InnerXml.ToLower().StartsWith('b'))
                {
                    Console.WriteLine(node.InnerXml);
                }
               
            }
        }
    }
}

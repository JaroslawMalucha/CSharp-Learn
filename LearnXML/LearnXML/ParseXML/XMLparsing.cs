using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParseXML
{
    public class XMLparsing
    {
        public static void test()
        {
            //testXMLreader01();
            //testXMLdocument01();
            test1();
            test2();
            write1();
        }
        public static void testXMLreader01()
        {
            XmlReader xmlReader = XmlReader.Create("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "Cube"))
                {
                    if (xmlReader.HasAttributes)
                        Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));
                }
            }
        }

        static void testXMLdocument01()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.ecb.int/stats/eurofxref/eurofxref-daily.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[2].ChildNodes[0].ChildNodes)
                Console.WriteLine(xmlNode.Attributes["currency"].Value + ": " + xmlNode.Attributes["rate"].Value);
        }

        static void test1()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml("<user name=\"John Doe\">A user node</user>");
            Console.WriteLine(xmlDoc.DocumentElement.Name);
            Console.WriteLine(xmlDoc.DocumentElement.InnerText);
            if (xmlDoc.DocumentElement.Attributes["name"] != null)
                Console.WriteLine(xmlDoc.DocumentElement.Attributes["name"].Value);
            if (xmlDoc.DocumentElement.Attributes["age"] != null)
                Console.WriteLine(xmlDoc.DocumentElement.Attributes["age"].Value);
            xmlDoc.LoadXml("<users><user>InnerText/InnerXml is here</user></users>");
            Console.WriteLine("OuterXml: " + xmlDoc.DocumentElement.OuterXml);
            Console.WriteLine("InnerXml: " + xmlDoc.DocumentElement.InnerXml);
            Console.WriteLine("InnerText: " + xmlDoc.DocumentElement.InnerText);
        }

        static void test2()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNode titleNode = xmlDoc.SelectSingleNode("//rss/channel/title");
            if (titleNode != null)
                Console.WriteLine(titleNode.InnerText);
        }

        static void test3()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNodeList itemNodes = xmlDoc.SelectNodes("//rss/channel/item");
            foreach (XmlNode itemNode in itemNodes)
            {
                
                XmlNode titleNode = itemNode.SelectSingleNode("title");
                XmlNode dateNode = itemNode.SelectSingleNode("pubDate");
                if ((titleNode != null) && (dateNode != null))
                    Console.WriteLine(dateNode.InnerText + ": " + titleNode.InnerText);
            }

            XmlNodeList titleNodes = xmlDoc.SelectNodes("//rss/channel/item/title");
            foreach (XmlNode titleNode in titleNodes)
                Console.WriteLine(titleNode.InnerText);

        }


        static void write1()
        {
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("users");

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "42");
            xmlWriter.WriteString("John Doe");
            xmlWriter.WriteEndElement();

            xmlWriter.WriteStartElement("user");
            xmlWriter.WriteAttributeString("age", "39");
            xmlWriter.WriteString("Jane Doe");

            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }


        static void write2()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("users");
            xmlDoc.AppendChild(rootNode);

            XmlNode userNode = xmlDoc.CreateElement("user");
            XmlAttribute attribute = xmlDoc.CreateAttribute("age");
            attribute.Value = "42";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = "John Doe";
            rootNode.AppendChild(userNode);

            userNode = xmlDoc.CreateElement("user");
            attribute = xmlDoc.CreateAttribute("age");
            attribute.Value = "39";
            userNode.Attributes.Append(attribute);
            userNode.InnerText = "Jane Doe";
            rootNode.AppendChild(userNode);

            xmlDoc.Save("test-doc.xml");
        }


        static void write3()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("test-doc.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//users/user");
            foreach (XmlNode userNode in userNodes)
            {
                int age = int.Parse(userNode.Attributes["age"].Value);
                userNode.Attributes["age"].Value = (age + 1).ToString();
            }
            xmlDoc.Save("test-doc.xml");
        }


    }
}

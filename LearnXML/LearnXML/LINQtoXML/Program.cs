using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Linq;
using System.Xml.Schema;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace LINQtoXML
{
    class Program
    {
        const string studentsXMLpath = @"D:\Jarek\Projects\CSharp\_JMproj\CSharpKnowledge\LINQtoXML\Students.xml";
        const string studentsCSVpath = @"D:\Jarek\Projects\CSharp\_JMproj\CSharpKnowledge\LINQtoXML\Students.csv";
        const string studentsHTMpath = @"D:\Jarek\Projects\CSharp\_JMproj\CSharpKnowledge\LINQtoXML\Students.htm";
        const string studentsXMLtransfomredPath = @"D:\Jarek\Projects\CSharp\_JMproj\CSharpKnowledge\LINQtoXML\StudentsTransformed.xml";
        const string studentsXMLschemaPath = @"D:\Jarek\Projects\CSharp\_JMproj\CSharpKnowledge\LINQtoXML\Students.xsd";

        static void Main(string[] args)
        {
            //CreateStudentDataXMLFileFromSourceCode();
            //CreateStudentDataXMLFileFromObjects();
            //PrintNames();
            //AddStudentElementAsLast();
            //AddStudentElementAsFirst();
            //AddStudentElementAtSpecificLocation();
            //MinifyXMLfile();
            //DeMinifyXMLfile();
            //ChangeExistingElementsValue();
            //UpdateExistingComment();
            //RemoveExistingElement();
            //RemoveAllInRootElements();
            //RemoveAllComments();

            //CreateStudentDataXMLFileFromObjects();
            //AddStudentElementAsFirst();
            //AddStudentElementAsFirst();

            //TransformXMLtoCSV();
            //TransformXMLtoHTMLtable();
            //TransformXMLtoXML();

            ValidateXML();
        }

        public static void ValidateXML()
        {
            XmlSchemaSet schema = new XmlSchemaSet();
            //schema.Add("http://tempuri.org/Students.xsd", studentsXMLschemaPath);
            schema.Add("", studentsXMLschemaPath);


            XDocument doc = XDocument.Load(studentsXMLpath);

            bool validationErrors = false;
            

            doc.Validate(schema, (s, e) =>
                    {
                        Console.WriteLine(e.Message);
                        validationErrors = true;
                    }
                );

            if (validationErrors)
            {
                Console.WriteLine("Validation failed");
            }
            else
            {
                Console.WriteLine("Validation succeeded");
            }
        }


        public static void TransformXMLtoXML()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);

            XDocument result = new XDocument(
                new XElement("Students",
                    new XElement("id-105",
                        from s in xDocument.Descendants("Student")
                        where s.Attribute("Id").Value == "105"
                        select new XElement("Student",
                            new XElement("Name", s.Element("Name").Value),
                            new XElement("Gender", s.Element("Gender").Value),
                            new XElement("TotalMarks", s.Element("TotalMarks").Value)
                            )
                        ),
                    new XElement("id-Other",
                        from s in xDocument.Descendants("Student")
                        where s.Attribute("Id").Value != "105"
                        select new XElement("Student",
                            new XElement("Name", s.Element("Name").Value),
                            new XElement("Gender", s.Element("Gender").Value),
                            new XElement("TotalMarks", s.Element("TotalMarks").Value)
                            )
                        )
                    )
                );
            result.Save(studentsXMLtransfomredPath);
        }



        public static void TransformXMLtoHTMLtable()
        {
            XDocument result = new XDocument(
                new XElement("table",
                    new XAttribute("border", 1),
                    new XElement("thead",
                        new XElement("tr",
                            new XElement("th", "Id"),
                            new XElement("th", "Name"),
                            new XElement("th", "Gender"),
                            new XElement("th", "TotalMarks")
                            )
                        ),
                    new XElement("tbody",
                        from student in XDocument.Load(studentsXMLpath).Descendants("Student")
                        select new XElement("tr",
                            new XElement("td", student.Attribute("Id").Value),
                            new XElement("td", student.Element("Name").Value),
                            new XElement("td", student.Element("Gender").Value),
                            new XElement("td", student.Element("TotalMarks").Value)
                            )
                        )
                    )
                );
            result.Save(studentsHTMpath);
        }

        public static void TransformXMLtoCSV()
        {
            StringBuilder sb = new StringBuilder();
            string delimiter = ",";

            XDocument.Load(studentsXMLpath).Descendants("Student").ToList().ForEach(
                    element => sb.Append(element.Attribute("Id").Value + delimiter
                                        + element.Element("Name").Value + delimiter
                                        + element.Element("Gender").Value + delimiter
                                        + element.Element("TotalMarks").Value
                                        + "\r\n"
                                        )
                    );
            StreamWriter sw = new StreamWriter(studentsCSVpath);
            sw.WriteLine(sb.ToString());
            sw.Close();

        }


        static void RemoveAllComments()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Nodes().OfType<XComment>().Remove();
            xDocument.Save(studentsXMLpath);
        }

        static void RemoveAllInRootElements()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Root.Elements().Remove();
            xDocument.Save(studentsXMLpath);
        }

        static void RemoveExistingElement()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Root.Elements().Where(x => x.Attribute("Id").Value == "105").FirstOrDefault().Remove();
            xDocument.Save(studentsXMLpath);
        }

        static void UpdateExistingComment()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Nodes().OfType<XComment>().FirstOrDefault().Value = "Updated Comment";
            xDocument.Save(studentsXMLpath);
        }


        static void ChangeExistingElementsValue()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Element("Students")
                            .Elements("Student") // returns IEnumerable<XElement>
                                                 //.Where(x => x.Attribute("Id").Value == "105").FirstOrDefault()
                                                 //.SetElementValue("TotalMarks", 999);
                                                 // OR
                            .Where(x => x.Attribute("Id").Value == "105")
                            .Select(x => x.Element("TotalMarks")).FirstOrDefault().SetValue(999);


            xDocument.Save(studentsXMLpath);
        }


        static void MinifyXMLfile()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Save(studentsXMLpath, SaveOptions.DisableFormatting);
            // CTR + K, CTRL + D - autoformt XML, or any othher code
        }

        static void DeMinifyXMLfile()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Save(studentsXMLpath, SaveOptions.None);
            // CTR + K, CTRL + D - autoformt XML, or any othher code
        }

        static void AddStudentElementAtSpecificLocation()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Element("Students")
                            .Elements("Student") // returns IEnumerable<XElement>
                            .Where(x => x.Attribute("Id").Value == "103").FirstOrDefault()
                //.Where(x => int.Parse(x.Attribute("Id").Value) == 103).FirstOrDefault()
                .AddBeforeSelf(
                new XElement("Student",
                    new XAttribute("Id", 105),
                    new XElement("Name", "Todd"),
                    new XElement("Gender", "Male"),
                    new XElement("TotalMarks", 980)
                    )
                );
            xDocument.Save(studentsXMLpath);
        }


        static void AddStudentElementAsFirst()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Element("Students").AddFirst(
                new XElement("Student",
                    new XAttribute("Id", 105),
                    new XElement("Name", "Todd"),
                    new XElement("Gender", "Male"),
                    new XElement("TotalMarks", 980)
                    )
                );
            xDocument.Save(studentsXMLpath);
        }

        static void AddStudentElementAsLast()
        {
            XDocument xDocument = XDocument.Load(studentsXMLpath);
            xDocument.Element("Students").Add(
                new XElement("Student",
                    new XAttribute("Id", 105),
                    new XElement("Name", "Todd"),
                    new XElement("Gender", "Male"),
                    new XElement("TotalMarks", 980)
                    )
                );
            xDocument.Save(studentsXMLpath);
        }


        static void PrintNames()
        {
            IEnumerable<string> names = from student in XDocument.Load(studentsXMLpath)
                                                                //.Descendants("Student")
                                                                .Element("Students").Elements("Student")
                                        where (int)student.Element("TotalMarks") > 800
                                        orderby (int)student.Element("TotalMarks") descending
                                        select student.Element("Name").Value;
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


        static void CreateStudentDataXMLFileFromObjects()
        {
            XDocument xDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating an XML Tree using LINQ to XML"),
                new XElement("Students",
                    from student in Student.GetAllStudents()
                    select new XElement("Student",
                                new XAttribute("Id", student.Id),
                                new XElement("Name", student.Name),
                                new XElement("Gender", student.Gender),
                                new XElement("TotalMarks", student.TotalMarks)
                                )
                    )
                );
            xDocument.Save(studentsXMLpath);
        }


        static void CreateStudentDataXMLFileFromSourceCode()
        {
            XDocument xDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Creating an XML Tree using LINQ to XML"),
                new XElement("Students",
                    new XElement("Student",
                        new XAttribute("id", 101),
                        new XElement("Name", "Mark"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", "800")
                        ),
                    new XElement("Student",
                        new XAttribute("id", 102),
                        new XElement("Name", "Rosy"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", "900")
                        ),
                    new XElement("Student",
                        new XAttribute("id", 103),
                        new XElement("Name", "Pam"),
                        new XElement("Gender", "Female"),
                        new XElement("TotalMarks", "850")
                        ),
                    new XElement("Student",
                        new XAttribute("id", 104),
                        new XElement("Name", "John"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", "950")
                        )
                    )
                );

            xDocument.Save(studentsXMLpath);
        }
    }
}

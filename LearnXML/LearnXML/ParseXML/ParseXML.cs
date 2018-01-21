using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParseXML
{
    public class ParseXML
    {
        // Daniel Sahal
        public static string return_config, return_config2;
        public static void testParseXML()
        {
            string path = @"D:\Jarek\Projects\VBA Projects\Projects 2017-09-22\C#\Parse_XML\Parse_XML\Parse_XML\TMD5.0_config.xml";
            string nodes_to_find_parameters = "/TMD_5_0/Job_parameters";
            string nodes_to_find_cfg = "/TMD_5_0/Job_file_config/File_config";
            string nodes_to_find_fields = "/TMD_5_0/Job_file_config/Job_field_map";
            string parameter;
            int cfg_no;
            Get_parameters get_parameters = new Get_parameters();
            Get_file_config get_config = new Get_file_config();

            parameter = get_parameters.do_magic(path, nodes_to_find_parameters, "PAR_Client",  0);
            cfg_no = get_config.get_count(path, nodes_to_find_cfg);

            Console.WriteLine(parameter);

            for (int z = 1; z <= cfg_no; z++)
            {
                return_config = get_config.do_magic(path, nodes_to_find_cfg, "FLs_cfg_name", z);
                return_config = String.Concat(return_config, " - ", get_config.do_magic(path, nodes_to_find_cfg, "FLs_path", z));
                Console.WriteLine(return_config);
            }

            // Console.WriteLine(cfg_no);



            Console.ReadKey();

        }


        public class Get_parameters
        {
            public static int counter { get; set; }
            public XmlNodeList nodes;
            public string return_string { get; set; }
            public virtual void Load_XML(string filepath, string nodes_to_select)
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(filepath);

                nodes = doc.DocumentElement.SelectNodes(nodes_to_select);

            }

            public virtual string fetch_data(string searched_data, int list_count)
            {
                foreach (XmlNode node in nodes)
                {
                    return_string = node.SelectSingleNode(searched_data).InnerText;
                }

                return return_string;
            }

            public string do_magic(string filepath, string nodes_to_select, string searched_data, int list_count)
            {
                Load_XML(filepath, nodes_to_select);
                fetch_data(searched_data, list_count);
                return return_string;
            }
        }

        public class Get_file_config : Get_parameters
        {

            public override void Load_XML(string filepath, string nodes_to_select)
            {
                base.Load_XML(filepath, nodes_to_select);
            }

            public override string fetch_data(string searched_data, int list_count)
            {
                counter = 0;
                foreach (XmlNode node in nodes)
                {
                    counter++;
                    if (counter == list_count)
                    {
                        return_string = node.SelectSingleNode(searched_data).InnerText;
                    }

                }
                return return_string;
            }
            public virtual int get_count(string filepath, string nodes_to_select)
            {
                counter = 0;
                Load_XML(filepath, nodes_to_select);
                foreach (XmlNode node in nodes)
                {
                    counter++;
                }
                return counter;
            }


        }
    }
}

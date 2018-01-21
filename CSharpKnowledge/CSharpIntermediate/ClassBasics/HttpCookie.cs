using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.ClassBasics
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }

        // INDEXER !!!
        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary[key] = value;
            }
        }
        
        public static void testHttpCookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Sep";
            Console.WriteLine(cookie["name"]);
            
        }
    }
}

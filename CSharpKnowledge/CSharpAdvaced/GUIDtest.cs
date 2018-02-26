using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class GUIDtest
    {
        public static void test()
        {
            // GUID - global unique identifier

            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);

            guid = Guid.NewGuid();
            Console.WriteLine(guid);

            guid = new Guid();
            Console.WriteLine(guid);


        }
    }
}

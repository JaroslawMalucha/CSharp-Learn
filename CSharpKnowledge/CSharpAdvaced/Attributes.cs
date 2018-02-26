using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CSharpAdvanced
{
    class Attributes
    {
        public static void test()
        {
            NestedForTest.SayHi();
            NestedForTest.SayHello();


            // REFLECTION
            // - can be used to acccess attributes at runtime

            MemberInfo memberInfo = typeof(Animals);
            object[] attributes = memberInfo.GetCustomAttributes(true);

            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }

        class NestedForTest // just to simulate an API built by someone else
        {
            // will not compile if error: true in Obsolete
            // squigly lines come from this attribute
            [Obsolete("This method is not going to be included in the upcoming version", error: false)]
            public static void SayHi() { }
            public static void SayHello() { }
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)] // marks as attribute and configures it
        public class Developer : System.Attribute // allows to use as attrubite
        {
            private string developerName;
            private bool isReviewed;
            private string message;

            public Developer(string developerName, bool isReviewed, string message)
            {
                this.developerName = developerName;
                this.isReviewed = isReviewed;
                this.message = message;
            }

            public string DeveloperName
            { get => developerName; set => developerName = value; }

            public bool IsReviewed
            { get => isReviewed; set => isReviewed = value; }

            public string Message
            { get => message; set => message = value; }
        }



        [Developer("Ahmad Mohey", false, "This need to be finished by next friday")]
        [Obsolete]
        class Animals
        {

        }

    }
}

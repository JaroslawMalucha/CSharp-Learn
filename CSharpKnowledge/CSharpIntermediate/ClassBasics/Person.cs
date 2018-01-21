using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.ClassBasics
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static void testPerson()
        {
            //// OBJECT INITIALIZER SYNTAX !!!
            // this allows to NOT define multiple constructors so there is less mess
            // JM: imho that is a bad practice as it allows to set an object in an INVALID state
            //  ...also creates confusion on how to properly instantiate the object since, 
            //  ....opposite to constructors, this is not self-documenting

            var person = new Person
            {
                FirstName = "Leon",
                LastName = "Zawodowiec"
            };

            
        }

    }
}

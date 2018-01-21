using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.InheritanceVsComposition
{
    class Cat: Animal
    {
        public string Name; //hides animals Name
        public string Type { get; set; }//hides animals Type

        public new void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void Walk()
        {
            Console.WriteLine("Walking");
        }
    }
}

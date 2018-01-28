using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.InheritanceVsComposition
{
    public class Fish:Animal
    {

        // Has all behaviours and implementations of Animal
        // PLUS its Own Swim method

        public void Swim()
        {
            Console.WriteLine("Swimming"); 
        }
    }
}

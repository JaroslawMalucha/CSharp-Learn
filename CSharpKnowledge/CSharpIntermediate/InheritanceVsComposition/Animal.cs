using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.InheritanceVsComposition
{
    public class Animal
    {
        public string Name;
        public virtual string Type { get; set; }

        public Animal()
        {
            Console.WriteLine("Default Animal Constructor");
        }
        public Animal(string calledFrom)
        {
            Console.WriteLine("Animal Constructor from " + calledFrom);
        }

        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public virtual void Walk()
        {
            Console.WriteLine("Walking");
        }

        protected void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
}

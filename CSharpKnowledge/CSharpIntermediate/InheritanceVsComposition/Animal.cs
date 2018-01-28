using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.InheritanceVsComposition
{
    public class Animal
    {
        public string Name; // can be hidden
        public virtual string Type { get; set; }  //can be overriden

        public Animal()
        {
            Console.WriteLine("Default Animal Constructor");
        }
        public Animal(string calledFrom) // Contstructor overload
        {
            Console.WriteLine("Animal Constructor from " + calledFrom);
        }

        public void Eat() // can be hidden
        {
            Console.WriteLine("Eating");
        }

        public virtual void Walk() //can be overriden
        {
            Console.WriteLine("Walking");
        }

        protected void Sleep() // can be hidden
        {
            Console.WriteLine("Animal is sleeping");
        }
    }
}

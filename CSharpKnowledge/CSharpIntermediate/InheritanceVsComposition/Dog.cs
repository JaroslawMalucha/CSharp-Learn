using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.InheritanceVsComposition
{
    public class Dog: Animal // only one parent is possible due to Diamond conflict
    {
        public new string Name; //hides animals Name // the "new" keyword is optional but should be used
        public override string Type { get; set; }    //hides animals Type

        public Dog()
        {
            Console.WriteLine("I am a Dog, a nobodys Dog, I have no name... I am so sad.");
        }
        public Dog(string name)
            : base(name) // calls this classes other constructor
        {
            Console.WriteLine("My name is {0}, I am a Dog", name);
        }

        public new void Eat() // hides Animal.Eat(), if Dog is casted to Animal, Eat() will be called from the Animal implementation not the Dog implementation even though the object is a Dog
        {
            Console.WriteLine("Eating");
        }

        public override void Walk() // overrides Animal.Walk(), if Dog is casted to Animal, Walk() will be called from the Dog implementation; requires Animal.Dog() to be declared as virtual, abstract or override
        {
            Console.WriteLine("Walking");
        }

        public new void Sleep()
        {
            base.Sleep();
        }
    }
}

using System;
using System.Collections;

namespace CSharpIntermediate.InheritanceVsComposition
{
    public static class AnimalTesting
    {
        public static void testAnimals()
        {
            // 2 TYPES OF RELATIONSHIPS BETWEEN CLASSES:
            //INHERITANCE => Is-A relationship
            //    - very tight coupling
            //    - fragile hierarchies
            //    - imagine an Onion with layers, thats inheritance, unfortuanately sometimes we need to twist the layers
            //COMPOSITION => Has-A relationship
            //    - Flexible
            //    - Looser coupling
            //    - imagine lego, we just stick them together as we like, its easy


            //notice the issue with INHERITANCE:
            //    E.G.
            //    - dog and human can use walk and thats how we created the hierarchy...b
            //        ...but after some we need to add a Fish to the hierarchy...
            //        ...what about fish? it needs to swim instead of walk!...
            //        ...so now we have a problem since we need to change the whole hierarchy:
            //            - remove Walk from Animal
            //            - reimplement specific Walk and Swim methods...
            //                ...that is A lot of Refactoring and can break the application
            //            - otherwise we could reconceptiualize interfaces from Walk() and Swim() into Move()...
            //                ...but that is A lot of Refactoring and can break the application
            //      - ALSO adding any methods to the Animal will require to rethink the application
            //          ... and possibly implement them for all derived classes
            //      - ALSO ALL changed classes and All using classes need to be recompiled and redployed !!!

            //its usually much better to use COMPOSITION, then you can just create classes:
            //  - Animal()  (without any walking or moving)
            //  - Walkable()
            //  - Swimable()
            // And just freely use only those classes and only those of their methods you need
            // This will allow to easily modify the aplication and all the dependencies.

            Dog brian = new Dog("Brian");

            Dog dog = new Dog();
            dog.Eat();
            dog.Walk();
            Animal animal = new Animal();
            //animal.Sleep(); // unaccessible from Animal since its protected
            dog.Sleep(); // accessible from Dog



            // UPCASTING and DOWNCASTING
            // Most important rules:  
            //  - Liskov Substitution Principle
            //  - Re-Generalisation is allowed, i.e. casting Dog to Animal
            //  - Re-Specification is not allowed, i.e. casting Animal to Dog

            // OUR HIERARCHY:
            //          Animal      - Base class - behaves and interacts like an animal
            //          /     \
            //        Dog     Fish  - Dervied class - behaves* and interacts both like a Dog/Fish and Animal* at the same time (behaviour is usually not full due to Overriding and/or hiding)

            // what works:
            Dog nativeDog = new Dog();              //created Dog object
            Animal upcastedDog = nativeDog;         //upcasted Dog object to Animal object to limit its interface, inside its still a Dog and behaves like a Dog; (AUTOMATIC) always works re: Liskov Substitution Principle
            Dog downcastedDog = (Dog)upcastedDog;  //downcasted Animal object(remember in this case it was actually a Dog inside) back to Dog object to access its interface (EXPLICIT) might not work if Animal object contains something more specific then a Dog or a sidebrached object like a Fish
            // eplanation: here an Animal type variable served as a container for a Dog object so it was ok to downcast that Dog object back to a Dog variable


            // what doesnt work:
            Animal nativeAnimal = new Animal();         // created an Animal object
            try
            {
                Dog downcastedAnimal = (Dog)nativeAnimal;  // tried to downcast an Animal to a Dog but animal is not a Dog! so we got an Exception thrown, i.e. Animal does not have the interfaces nor the behaviours that Dog has and cannot become more specific than it is
            }
            catch (Exception)
            {
                Console.WriteLine("Cant downcast non-dog animal to a dog type.");
            }

            Fish fish = new Fish();
            //Dog sidecastedDog  = (Dog) fish;      // this will not compile, the compiler knows both specific types and disallows that
            Animal upcastedFish = fish;
            try
            {
                Dog sidecastedFish = (Dog)upcastedFish; // this will compile, the Super class acts as an obfuscator to the compiler, the compiler cannot knwo which actual Type will be inside the Animal variable => throws Exception when not compatible
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot cast a Fish to a Dog");
            }


            // OVERRIDING vs HIDING
            // - OVERRIDING is stronger - given object will always behave like itself, nonwithstanding where it has been casted to, e.g. (Animal)Dog.OverridenMethod will behave like a Dog
            // - HIDING is weaker - given object will behave like its casted-to Base type, e.g. (Animal)Dog.HiddenMethodOrField will behave like an Animal


            //// BOXING and UNBOXING
            // - has a performance penalty
            // - unboxing is not type safe
            // - instead of boxing/unboxing use Generic implementation of Clases, e.g. Generic Collections

            // BOXING - works like UPCASTING - converting value type to a reference type
            object oInt = 1; // CLR boxes the value type double into an object and places it as a new variable on the Heap instead of a Stack
            // UNBOXING - works like DOWNCASTING - converting reference type to a value type
            int vI = (int)oInt; // CLR unboxes the reference type object that containes a double and places it from the Heap to the Stack as new variable

            //e.g.
            // BOXING
            var list = new ArrayList(); // non-generic ArrayList that stores objects
            list.Add(1); // auto-boxing happens to store the number as an object on a heap
            list.Add("Prince");
            list.Add(DateTime.Today);

            // UNBOXING
            try
            {
                int i = (int)list[2];
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot cast value '{0}' to an int");
            }

        }
    }
}

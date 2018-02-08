namespace CSharpIntermediate.ClassBasics
{
    public static class ClassBasics
    {
        ////BASIC Basics structure od all applications, layers:
        // Presentation
        // Business Logic / Domain
        // Data Access / Persistance

        ////TWO BAISC TYPES OF COMPONENTS:
        // Data (fields)
        // Behaviour (methods)

        ////UML REPRESENTATION:
        //-----------
        //  Person
        //-----------
        // Name: string
        // BirthDate: DateTime
        //-----------
        // Age()
        // Walk()
        // Eat()
        //-----------

        ////NAMING CONVENTIONS:
        // PascalCase - constants, Public Accessors, Classes
        // camelCase - local variables, arguments
        // _camelCase - private fields

        ////NATURE
        // Class - a template, and a module; has static class components
        // Object - instance; has instance components

        //// OOP MAIN CONCEPTS - OOP FOUR PILLARS:
        // Abstraction
        // Encapsulation
        // Polymorphism
        // Inheritance

        //// GOOD PRACTICE:
        // Encapsulate as much as possible(meaningful,productive) - hide implementation, expose interface for communication
        // OBJECTS MUST ALLWAYS BE IN A VALID STATE
        // Set access permissions as restrictive as possible to disallow accidentaly making an Object INVALID

        //// ACCESS MODIFIERS in order from most accsible to least acessible:
        // Public - The type or member can be accessed by any other code in the same assembly or another assembly that references it.
        // Protected Internal - within same assembly OR within a child class of another assembly
        // Internal - (DEFAULT for classes) The type or member can be accessed by any code in the same assembly, but not from another assembly.
        // Protected - The type or member can be accessed only by code in the same class or struct, or in a class that is derived from that class.
        // Private - (DEFAULT for fields and methods) The type or member can be accessed only by code in the same class or struct.

        // OTHER MODIFIERS
        // sealed - prevents further inheritance for classes and further overriding for methods
        // static - for methods classes means its accessable via class and not via an object(the class object instance)
        //        ...for classes means can only have static members, cannot instantiate, implicitly sealed

        // NESTED CLASSES
        // - classes declared inside another class
        // - private by default
        // - benefits: 
        //      - does not pollute the global scope
        //      - nested class has full access to members of the parent class (also private members)
        //      - nested class that inherits from its parent abstract class: full control, denies sublassing

        // PARTIAL CLASSES
        // - just a class spread out on multiple files
        // - use [partial] in class declaration, eg. partial public class Person

        public static void testClassBasics()
        {
            Customer.testCustomer();
            Person.testPerson();
            HttpCookie.testHttpCookie();

        }

    }

}

// NAMESPACES

namespace testNamespace
{
    partial class partialClass
    {
        int age = 2;
    }
}

namespace testNamespace
{
    partial class partialClass
    {
        int eyes = 2;
        int x;
        testNamespace2.dummyClass y = new testNamespace2.dummyClass();
        public partialClass()
        {
            x = age * 2;
        }
    }

    namespace testNamespace2
    {
        class dummyClass
        {

        }
    }

}
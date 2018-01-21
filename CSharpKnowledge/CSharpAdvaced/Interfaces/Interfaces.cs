using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    interface IInterface
    {
        //// INTERFACES:
        // - are a CONTRACT static required public accessors (interfaces) of a class
        // - provide polymorphic behaviour
        // - result in loosly coupled classes
        // - class can implement multiple interfaces
        // - can be used, e.g. :
        //      - as runtime polymorhpism
        //      - for extensibility
        //      - with dependency injection

        //explicit implementation ?? to define which interface for multiple, overlapping interfacecs ??

        //// OCP: Open-CLose Principle - Software Entities should be open to extenion and closed to modification

        // QUICK REFACTOR:
        // - on implementing class declaration to auto-create stubs of implemented methods
        // - on any class declaration to auto-extract to create an interface based on the class methods

    }

}

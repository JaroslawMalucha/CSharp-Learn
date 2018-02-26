using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.ClassBasics
{

    public class Customer
    {
        // fields are initialized first automatically
        // auto initialization allows skipping the default constructor and 
        //  ...will ENSURE that any parameterized constructors will initialize this field (automatically)
        //  ...this simplifies control flow
        private readonly List<Order> orders = new List<Order>(); // this makes it readonly even inside the class -> gives us more rigid classes

        // readonly vs. const
        // readonly:
        // - runtime var (can be computed dynamically) -> so can be an object
        // - made readonly after constructor finishes
        // const:
        // - compile time (almost since can calculate on const e.g constC = constA + constB)
        // - implicitly static


        public string Name { get; set; } //auto property 
        public DateTime BirthDate { get; private set; } //auto property //private makes it readonly 
        public string ID { get; private set; } //auto property //private makes it readonly 
        public TimeSpan Age // normal property
        {
            get
            {
                return DateTime.Now - BirthDate;
            }
        }
        
        // CONSTRUCTOR OVERLOADING 
        // - the lack of default constructor disallows constructing the object without parameters
        // - signature identifying an overloaded method: name, parameter count and order, parameter types
        // - Overloading happens at compile time, hence can be checked by the compilers analyser during coding
        // - Overlaoding is a COMPILE TIME or STATIC POLYMORPHISM
        //      ...actuall RUNTIME POLYMORPHISM is achieved using Virtual Functions 
        //          ....(Inheritance, Interfaces, or loose typing, i.e. object type)
        // Watch out for:
        // - Implicit Type conversion of the parameters can make confusing which Constructor will be selected, e.g. double to int auto-cast
        // - Name Masking due to scoping can make confusing which Constructor will be selected, 
        //  ....e.g. a non public constructor may be inaccessible to the caller, hence a dfferent one will be chosen
        //  .........or prefered a dfferent one will be preferred due to looking into the innermost scope (same names ofc)

        public Customer(string name, DateTime birthDate )
        {
            ID = GenerateID();
        }
        public Customer(string ID, string name, DateTime birthDate)
        {
            this.ID = ID;
        }

        public void Walk()
        {
            Console.WriteLine("{0} is walking", Name);
        }

        private string GenerateID()
        {
            return new System.Random().Next(1, 1000000).ToString();
        }

        public static void testCustomer()
        {
            var customer = new Customer("Johnson", new DateTime(1987, 6, 13));
            var customer2 = new Customer("0000123", "Ankit", DateTime.Parse("1987-06-13"));
            Console.WriteLine(customer.BirthDate.ToString());
            Console.WriteLine(customer2.BirthDate.ToString());
        }
    }

    public class Order
    {
        public int ID;
    }

}

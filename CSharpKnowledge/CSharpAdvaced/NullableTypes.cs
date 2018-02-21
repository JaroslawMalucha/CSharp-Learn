using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class NullableTypes
    {
        public static void testNullable()
        {
            //those two declarations are equivalent
            Nullable<DateTime> dateX = null; 
            DateTime? dateNullable = null;

            Console.WriteLine("GetValueOrDefault(): " + dateNullable.GetValueOrDefault());
            Console.WriteLine("HasValue(): " + dateNullable.HasValue);
            try
            {
                Console.WriteLine("Value(): " + dateNullable.Value);
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot read value from as date is a nullable type of value null");
            }


            // assign nullable type to non-nullable type
            DateTime date = dateNullable.GetValueOrDefault();

            // assign non-nullable type to nullable type
            dateNullable = date;

            // Null Coalescing Operator
            //long
            if (dateNullable != null)
                date = dateNullable.GetValueOrDefault();
            else
                date = DateTime.Today;
            //short
            dateNullable = null;
            date = dateNullable ?? DateTime.Today; // Null Coalescing Operator
            date = (dateNullable != null) ? dateNullable.GetValueOrDefault() : DateTime.Today; // elvis operator

            // super short - skip if null
            Console.WriteLine(dateNullable?.ToLongDateString());

        }
    }
}

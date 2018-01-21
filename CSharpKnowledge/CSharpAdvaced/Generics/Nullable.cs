using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Generics
{
    class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(T value) 
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefautl()
        {
            if (HasValue)
                return (T)_value;
            return default(T);
        }


        public static void testNullable()
        {
            var num = new Nullable<int>(5);
            Console.WriteLine("Has value: " + num.HasValue);
            Console.WriteLine("Has value: " + num.GetValueOrDefautl());
        }

    }
}

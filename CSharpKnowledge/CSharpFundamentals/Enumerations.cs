using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public enum ShippingMethod : int
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    public enum ShippingMethod2 : int
    {
        RegularAirMail ,
        RegisteredAirMail =3 ,
        Express 
    }
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    class Enumerations
    {
        public static void testEnumerations()
        {
            ShippingMethod method = ShippingMethod.Express;
            Console.WriteLine(method);
            Console.WriteLine((int) method);
            Console.WriteLine((ShippingMethod)(int)method);
            Console.WriteLine(method.ToString());
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine((int)ShippingMethod2.RegularAirMail);
            Console.WriteLine((int)ShippingMethod2.RegisteredAirMail);
            Console.WriteLine((int)ShippingMethod2.Express);
        }

    }
}

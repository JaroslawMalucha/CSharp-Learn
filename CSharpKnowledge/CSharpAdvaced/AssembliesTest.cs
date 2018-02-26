using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Globalization;

namespace CSharpAdvanced
{
    class AssembliesTest
    {
        public static void test()
        {
            // ASSEMBLY
            // - basic unit a delivery of code

            //https://docs.microsoft.com/en-us/dotnet/framework/app-domains/assemblies-in-the-common-language-runtime
            //https://docs.microsoft.com/en-us/dotnet/api/system.reflection.assembly?f1url=https%3A%2F%2Fmsdn.microsoft.com%2Fquery%2Fdev15.query%3FappId%3DDev15IDEF1%26l%3DEN-US%26k%3Dk(System.Reflection.Assembly);k(TargetFrameworkMoniker-.NETFramework,Version%3Dv4.6.1);k(DevLang-csharp)%26rd%3Dtrue&view=netframework-4.7.1

            System.Reflection.Assembly assembly = Assembly.GetEntryAssembly();
            System.Reflection.Assembly assembly2 = Assembly.GetExecutingAssembly();

            AssemblyName assemblyName = assembly.GetName();

            Console.WriteLine(assemblyName.FullName);
            Console.WriteLine(assemblyName.CultureName);
            Console.WriteLine(assemblyName.CultureInfo);
            Console.WriteLine(assemblyName.ContentType);
            Console.WriteLine(assemblyName.VersionCompatibility);



            // CULTURE INFO
            //https://msdn.microsoft.com/en-us/library/system.globalization.cultureinfo(v=vs.110).aspx
            //http://deanhume.com/home/blogpost/hidden-gems-inside--net-classes/74

            CultureInfo cultureInfo = new CultureInfo("en-GB");

            assemblyName.CultureInfo = cultureInfo;
            Console.WriteLine(assemblyName.CultureInfo.DisplayName);
            Console.WriteLine(assemblyName.CultureInfo.NativeName);
            Console.WriteLine(assemblyName.CultureInfo.NumberFormat.CurrencySymbol);
            Console.WriteLine(assemblyName.CultureInfo.Calendar);

            // APPLICATION VERSION
            Console.WriteLine(assemblyName.Version);
            assemblyName.Version = new Version(2, 0, 0, 0);
            Console.WriteLine(assemblyName.Version);

            // REGION INFO
            //http://deanhume.com/home/blogpost/hidden-gems-inside--net-classes/74
            //https://msdn.microsoft.com/en-us/library/system.globalization.regioninfo(v=vs.110).aspx

            RegionInfo regionInfo = new RegionInfo("AE");

            Console.WriteLine(regionInfo.DisplayName);
            Console.WriteLine(regionInfo.IsMetric);
            Console.WriteLine(regionInfo.CurrencyEnglishName);
            Console.WriteLine(regionInfo.ThreeLetterISORegionName);



        }
    }
}

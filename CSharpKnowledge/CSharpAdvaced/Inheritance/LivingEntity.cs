using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public abstract class LivingEntity
    {
        private static int _count;
        
        // constructor
        public LivingEntity() 
        {
            _count++;
        }

        // destructor or finilizer
        // http://www.c-sharpcorner.com/UploadFile/72d20e/concept-of-destructor-in-C-Sharp/
        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/destructors
        ~LivingEntity() 
        {
            _count--;
        }

        public static int Count { get { return _count; } }
        // sealed - keyword to use on an overriding method disallow further derivation; rarely used if ever; sealed classes are slightly faster due to some optimizations
    }

    public class Baby:LivingEntity
    {

        public static void testEntity()
        {

            // here you can see when Garbage Collectors kicks in 
            // - its not always obvious and sometimes you might need to trigger it explicitly, although usually its not a good practice
            CreateBabies();
            GC.Collect();
            Console.WriteLine(LivingEntity.Count);
            GC.WaitForPendingFinalizers();
            Console.WriteLine(LivingEntity.Count);
            GC.Collect();
            Console.WriteLine(LivingEntity.Count);
            GC.WaitForPendingFinalizers();
            Console.WriteLine(LivingEntity.Count);
        }


        public static void CreateBabies()
        {
            List<Baby> babies = new List<Baby>() { new Baby(), new Baby(), new Baby() };
            Console.WriteLine(LivingEntity.Count);
            babies = null;
            Console.WriteLine(Baby.Count);
        }

    }



}

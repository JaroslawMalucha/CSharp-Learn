﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public abstract class LivingEntity
    {
        private static int _count;

        public LivingEntity()
        {
            _count++;
        }
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

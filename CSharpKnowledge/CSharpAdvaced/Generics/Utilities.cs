using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// T where : 
// IComparable - to take only object that can be compared
// Product - only type safe
// struct - 
// class
// new() - has default costructor


namespace CSharpAdvanced.Generics
{
    class Utilities<T> where T : IComparable, new()
    {
        public T Max(T a, T b) 
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSmothing(T value)
        {
            var obj = new T();
        }

    }
}

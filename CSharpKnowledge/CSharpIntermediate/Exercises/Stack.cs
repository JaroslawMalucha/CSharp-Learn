using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate.Exercises
{
    public class Stack
    {

        // use generics to make this efficient => currently this does boxing/unboxing and hence there is a performance penalty

        private List<object> stack = new List<object>();

        public void Push(object item)
        {
            if (item == null)
                throw new InvalidOperationException("cannot stack a null reference", new NullReferenceException());
            stack.Add(item);
        }

        public object Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("cannot stack a null reference");
            object last = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return last;
        }

        public void Clear()
        {
            stack.Clear();
        }



        public static void testStack()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Generics
{
    class GenericDictionary<TKey,TValue> 
    {
        Dictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();
        public void Add(TKey key, TValue value)
        {
            dict.Add(key, value);
        }

        public TValue Get(TKey key)
        {
            return dict[key];
        }
    }
}

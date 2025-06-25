using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfType
{
    internal class OType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            List<T> list = new List<T>();
            foreach (var i in enumerable)
            {
                if (i is T t)
                {
                    list.Add(t);
                }
            }
            return list;
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return GetOfType<TOutput>(enumerable);
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            List<TBase> list = new List<TBase>();
            foreach (var derivedItem in derivedItems)
            {
                list.Add(derivedItem);
            }
            return list;
        }
    }
}

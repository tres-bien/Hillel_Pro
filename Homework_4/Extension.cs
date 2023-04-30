using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal static class Extension
    {
        public static KeyValuePair<TKey, TValue> GetPenultimate<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
            return dictionary.ElementAt(dictionary.Count - 2);
        }

        public static IPerson GetPenultimate(this IEnumerable<IPerson> person)
        {
            return person.ElementAt(person.Count() - 2);
        }
    }
}

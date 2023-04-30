using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class People : IEnumerable<IPerson>
    {
        protected List<IPerson> _people = new List<IPerson>();

        public IEnumerator<IPerson> GetEnumerator()
        {
            return _people.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<IPerson> Create(IPerson person)
        {
            person.Id = _people.Count;
            _people.Add(person);
            return _people;
        }

        public IEnumerable<IPerson> FilterByAgeMore(byte age)
        {
            return _people.Where(_people => _people.Age >= age);
        }

        public Dictionary<int, string> FilterByAgeAndSortAlfabetical(byte age)
        {
            return FilterByAgeMore(age)
                  .Select(_people => new { _people.Id, _people.Name })
                  .OrderBy(x => x.Name).ToDictionary(x => x.Id, x => x.Name);
        }

        public Dictionary<int[], string[]> FilterByAgeAndGroupByAge(byte age)
        {
            var a = FilterByAgeMore(age)
                  .OrderBy(x => x.Age)
                  .GroupBy(x => x.Age, x => new { Id = x.Id, Name = x.Name })
                  .ToDictionary(Id => Id.Select(x => x.Id).ToArray(), Name => Name.Select(x => x.Name).ToArray());
            return a;
        }

        public void Show()
        {
            foreach (IPerson person in _people)
            {
                Console.WriteLine(person);
            }
        }

        public void Show(IPerson person)
        {
            Console.WriteLine(person);
        }

        public void Show<TKey, TValue>(KeyValuePair<TKey[], TValue[]> persons)
        {
            for (int i = 0; i < persons.Value.Count(); i++)
            {
                Console.Write(persons.Key[i] + " ");
                Console.WriteLine(persons.Value[i]);
            }
        }

        public void Show<TKey, TValue>(KeyValuePair<TKey, TValue> persons)
        {
            Console.WriteLine(persons.Key + " " + persons.Value);
        }

        public void Show<TKey, TValue>(Dictionary<TKey[], TValue[]> persons)
        {
            for (int i = 0; i < persons.Count; i++)
            {
                for (int j = 0; j < persons.ElementAt(i).Value.Count(); j++)
                {
                    Console.Write(persons.ElementAt(i).Key[j] + " ");
                    Console.WriteLine(persons.ElementAt(i).Value[j]);
                }
            }
        }

        public void Show<TKey, TValue>(Dictionary<TKey, TValue> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(person.Key + " " + person.Value);
            }
        }

        public void Show(IEnumerable<IPerson> persons)
        {
            foreach (IPerson person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}

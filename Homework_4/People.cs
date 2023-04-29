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
                  .OrderBy(x => x.Name).ToDictionary(x => x.Id, y => y.Name);
        }

        public Dictionary<int, string> FilterByAgeAndGroupByAge(byte age)
        {
            return FilterByAgeMore(age)
                  .OrderBy(x => x.Age)
                  .Select(_people => new { _people.Id, _people.Name })
                  .ToDictionary(x => x.Id, y => y.Name);
        }

        public KeyValuePair<int, string> GetPenultimate(Dictionary<int, string> dictionary)
        {
            return dictionary.ElementAt(dictionary.Count - 2);
        }

        public IPerson GetPenultimate(IEnumerable<IPerson> person)
        {
            return person.ElementAt(person.Count() - 2);
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

        public void Show(KeyValuePair<int, string> person)
        {
            Console.WriteLine(person.Key + person.Value);
        }

        public void Show(Dictionary<int, string> persons)
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

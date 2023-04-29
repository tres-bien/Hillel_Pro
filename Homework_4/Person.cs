using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Person : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return $"{Id} Name: {Name}, Age: {Age}";
        }
    }
}

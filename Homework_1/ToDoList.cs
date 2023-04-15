using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class ToDoList : IToDoList
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public byte Day { get; set; }
        public byte Month { get; set; }
        public int Year { get; set; }
        public byte Hours { get; set; }
        public byte Minutes { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Day}/{Month}/{Year}, {Hours}:{Minutes} {Name};";
        }
    }
}

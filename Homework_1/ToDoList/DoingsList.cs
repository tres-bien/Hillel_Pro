using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class DoingsList : IDoingsList
    {
        public IEnumerable<IToDoList> Get()
        {
            return new List<IToDoList>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal delegate bool SaveDelegate(IEnumerable<IToDoList> task);

    internal interface ISaveable
    {
        event SaveDelegate SaveEvent;
    }
}

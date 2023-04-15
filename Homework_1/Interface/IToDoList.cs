using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal interface IToDoList : IData
    {
        string Name { get; set; }
        int Id { get; set; }
    }
}

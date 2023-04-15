using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal interface IProperty
    {
        string On { get; set;  }
        string Colour { get; set; }
        int Height { get; set; }
    }
}

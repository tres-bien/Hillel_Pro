using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Train : IPush, IPull
    {
        public void Pull()
        {
            Console.WriteLine("pull-pull"); ;
        }

        public void Push()
        {
            Console.WriteLine("shove-shove");
        }
    }
}

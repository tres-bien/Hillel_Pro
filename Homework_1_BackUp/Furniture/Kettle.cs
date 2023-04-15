using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Kettle : Furniture
    {
        public Kettle(string colour)
        {
            On = "грею";
            Colour = colour;
        }

        public override void GetColour() { base.GetColour(); }

        public override void GetName() { base.GetName(); }

        public override void Off() { base.Off(); }

    }
}

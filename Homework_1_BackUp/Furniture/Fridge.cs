using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class Fridge : Furniture
    {
        public Fridge(string colour)
        {
            On = "холожу";
            Colour = colour;
        }

        public override void GetName() { base.GetName(); }

        public override void Off() { base.Off(); }

        public override void GetColour() { base.GetColour(); }
    }
}

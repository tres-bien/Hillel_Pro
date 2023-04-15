using System;
using System.Collections;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal abstract class Furniture : IProperty, IFurniture, IGetName
    {
        public string On { get; set; }
        public string Colour { get; set; }
        public int Height { get; set; }

        public virtual void Off()
        {
            Console.WriteLine("не" + On);
        }

        public virtual void WhenOn()
        {
            Console.WriteLine(" " + On);
        }

        public virtual void GetName()
        {
            Console.WriteLine(nameof(TagClass));
        }
        public virtual void GetColour()
        {
            Console.Write(Colour);
        }
    }
}

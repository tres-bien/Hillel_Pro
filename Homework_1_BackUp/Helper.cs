using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal static class Helper
    {
        public static void MakeOutput(List<IProperty> list)
        {
            foreach (IProperty f in list)
            {
                Console.WriteLine($"{f.On} {f.Colour}");
            }
        }
        

        public static void Run()
        {
            var list = new List<IProperty>();
            Console.OutputEncoding = Encoding.Unicode;

            var fridge = new Fridge("желтый") { Height = 100 };

            var kettle = new Kettle("синий") { Height = 5 };

            var lamp = new Lamp("белый") { Height = 20 };

            list.Add(fridge); list.Add(kettle); list.Add(lamp);

            MakeOutput(list);
        }
    }
}

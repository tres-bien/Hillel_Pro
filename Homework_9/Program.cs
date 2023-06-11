using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Xml.Linq;

namespace Homework_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var baseClass = new BaseClass();

            GetField("number", baseClass);
            SetField("number", 10, baseClass);
            GetField("number", baseClass);

            Console.WriteLine();
            SetField("name", "John", baseClass);
            SetField("number", 10, baseClass);
            GetField("name", baseClass);

            Console.WriteLine();
            Console.WriteLine(GetAllFields(baseClass));

            Console.WriteLine();
            SaveValue("name", baseClass, "Emma", baseClass.GetType());
            Console.WriteLine(GetAllFields(baseClass));

            Console.WriteLine();
            SaveValue("name", baseClass, "Dave");
            Console.WriteLine(GetAllFields(baseClass));

            Console.WriteLine("_________");

            Console.WriteLine(GetAllFields(SaveValue(GetAllFields(baseClass), baseClass)));
            //SaveValue("name", baseClass, "Eshly");
        }


        static void GetField(string field, BaseClass baseClass)
        {
            Console.WriteLine(typeof(BaseClass).GetField(field).GetValue(baseClass));
        }

        static void SetField<T>(string field, T prop, BaseClass baseClass)
        {
            typeof(BaseClass).GetField(field).SetValue(baseClass, prop);
        }

        static string GetAllFields<T>(T baseClass)
        {
            string str = string.Empty;
            foreach (var item in baseClass.GetType().GetFields())
            {
                if (Attribute.IsDefined(item, typeof(DisplayNameAttribute)))
                {
                    var attribute = Attribute.GetCustomAttribute(item, typeof(DisplayNameAttribute)) as DisplayNameAttribute;
                    var name = attribute?.Name;

                    str += $"{name ?? item.Name}:{item.GetValue(baseClass)}";
                    foreach (var attr in item.GetCustomAttributes(false))
                    {
                        str += $"[{attr.GetType().Name}]";
                    }
                }
                else
                    str += $"{item.Name}:{item.GetValue(baseClass)};";
            }
            return str;
        }

        static string GetAllFields2<T>(T baseClass)
        {
            string str = string.Empty;
            foreach (var item in baseClass.GetType().GetFields())
            {
                var attribute = Attribute.GetCustomAttribute(item, typeof(DisplayNameAttribute)) as DisplayNameAttribute;
                var name = attribute?.Name;
                str += $"{name ?? item.Name}:{item.GetValue(baseClass)};";
            }
            return str;
        }

        static T SaveValue<T>(string prop, T obj)
        {
            var a = StringArr(prop);
            var newType = Activator.CreateInstance(obj.GetType());
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].Count > 2)
                {
                    for (int j = 2; j < a[i].Count; j++)
                    {
                        if (a[i][j] == "DisplayNameAttribute")
                        {

                        }
                    }
                }
                SetField(obj, a, newType, i);
            }
            return obj;
        }

        static void SetField<T>(T obj, List<List<string>> a, object? newType, int i)
        {
            if (int.TryParse((a[i][1]), out int value))
            {
                newType.GetType().GetField(a[i][0]).SetValue(obj, int.Parse(a[i][1]));
            }
            else
                newType.GetType().GetField(a[i][0]).SetValue(obj, a[i][1]);
        }

        static List<List<string>> StringArr(string prop)
        {
            var list = new List<List<string>>();
            var arr = prop.Split(';', StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in arr)
            {
                list.Add(item.Split(new char[] { '[', ']', ':' }, StringSplitOptions.RemoveEmptyEntries).ToList());
            }

            return list;
        }

        static object SaveValue(string prop, object obj, string val, Type type)
        {
            type.GetField(prop).SetValue(obj, val);
            return obj;
        }

        static T SaveValue<T>(string prop, T obj, string val)
        {
            obj.GetType().GetField(prop).SetValue(obj, val);
            return obj;
        }
    }

    internal class BaseClass
    {
        public int number;
        [DisplayName("firstName")]
        public string name;
    }

    internal class DisplayNameAttribute : Attribute
    {
        public DisplayNameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
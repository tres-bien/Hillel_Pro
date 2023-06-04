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
            GetField("name", baseClass);

            Console.WriteLine();
            Console.WriteLine(GetAllFields(baseClass));

            Console.WriteLine();
            SaveValue("name", baseClass, "Emma", baseClass.GetType());
            Console.WriteLine(GetAllFields(baseClass));
            
            Console.WriteLine();
            SaveValue("name", baseClass, "Dave");
            Console.WriteLine(GetAllFields(baseClass));
        }


        static void GetField(string field, BaseClass baseClass)
        {
            Console.WriteLine(typeof(BaseClass).GetField(field).GetValue(baseClass));
        }

        static void SetField<T>(string field, T prop, BaseClass baseClass)
        {
            typeof(BaseClass).GetField(field).SetValue(baseClass, prop);
        }

        static string GetAllFields(BaseClass baseClass)
        {
            string str = string.Empty;
            foreach (var item in baseClass.GetType().GetFields())
            {
                str += $"{item.Name}:{item.GetValue(baseClass)};\n";
            }
            return str;
        }

        static object SaveValue(string prop ,object obj ,string val, Type type)
        {
            type.GetField(prop).SetValue(obj, val);
            return obj;
        }
        
        static T SaveValue<T>(string prop ,T obj ,string val)
        {
            obj.GetType().GetField(prop).SetValue(obj, val);
            return obj;
        }
    }

    internal class BaseClass
    {
        public int number;
        public string name;
    }
}
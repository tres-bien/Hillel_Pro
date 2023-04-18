using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_1
{
    internal class FileProcessor : IDoingsList, IListSaveable
    {
        public bool Save(IEnumerable<IToDoList> items)
        {
            var fileName = new FileInfo(@"ToDo_List.txt");

            FileStream file = fileName.Create();

            StreamWriter writer = new StreamWriter(file, Encoding.Unicode);

            foreach (var item in items)
            {
                writer.WriteLine($"{item.Id},{item.DateTime},{item.Name},{item.Color};");
            }

            writer.Close();

            return fileName.Exists;
        }

        public IEnumerable<IToDoList> Get()
        {
            List<IToDoList> toDoList = new List<IToDoList>();

            var directory = new DirectoryInfo(".");

            if (directory.Exists)
            {
                FileInfo[] files = directory.GetFiles("*.txt");

                foreach (FileInfo file in files)
                {
                    if (file.Name == "ToDo_List.txt")
                    {
                        string path = file.FullName;
                        using (StreamReader reader = new StreamReader("ToDo_List.txt"))
                        {
                            string text = File.ReadAllText(path);
                            text = text.Trim('\n', '\r');
                            string[] toDoListArray = null;

                            string[] toDoListsArray = text.Split(new char[] { ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                            for (int i = 0; i < toDoListsArray.Length; i++)
                            {
                                toDoListArray = toDoListsArray[i].Split(',', StringSplitOptions.RemoveEmptyEntries);
                                toDoList.Add(new ToDoList { Id = int.Parse(toDoListArray[0]), 
                                                            DateTime = DateTime.Parse(toDoListArray[1]), 
                                                            Name = toDoListArray[2], 
                                                            Color = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), toDoListArray[3]) });
                            }
                        }
                    }
                }
            }

            return toDoList;
        }
    }
}

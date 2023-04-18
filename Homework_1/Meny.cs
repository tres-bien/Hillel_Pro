using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    enum EnumType : byte
    {
        Zero = 1,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Eleven,
        Twelve,
        Thirteen
    }
    
    internal class Meny
    {
        public void Run(EventList eventList, ReminderList reminderList, TaskList taskList)
        {
            bool showMeny = true;

            while (showMeny)
            {
                showMeny = MainMeny(eventList, reminderList, taskList);
            }
        }

        private bool MainMeny(EventList eventList, ReminderList reminderList, TaskList taskList)
        {
            EnumType enumType;
            int value;

            Console.Title = "### To-Do List ###";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("### To-Do List ###");
            Console.WriteLine(new string('_', 50));
            Console.Write("\nChose action:" +
                          "\n1 - Show events" +
                          "\n2 - Show reminds" +
                          "\n3 - Show tasks" +
                          "\n4 - Create event" +
                          "\n5 - Create remind" +
                          "\n6 - Create task" +
                          "\n7 - Remove event" +
                          "\n8 - Remove remind" +
                          "\n9 - Remove task" +
                          "\n10 - Update event" +
                          "\n11 - Update remind" +
                          "\n12 - Update task" +
                          "\n13 - Exit" +
                          "\n\n\rSelect an option: ");

            int.TryParse(Console.ReadLine(), out value);

            enumType = (EnumType)value;

            switch (enumType)
            {
                case EnumType.Zero:
                    NewLine();
                    return Show(eventList);

                case EnumType.One:
                    NewLine();
                    return Show(reminderList);

                case EnumType.Two:
                    NewLine();
                    return Show(taskList);

                case EnumType.Three:
                    NewLine();
                    return Create(eventList);

                case EnumType.Four:
                    NewLine();
                    return Create(reminderList);

                case EnumType.Five:
                    NewLine();
                    return Create(taskList);

                case EnumType.Six:
                    NewLine();
                    return false;

                case EnumType.Seven:
                    break;
                case EnumType.Eight:
                    break;
                case EnumType.Nine:
                    break;
                case EnumType.Ten:
                    break;
                case EnumType.Eleven:
                    break;
                case EnumType.Twelve:
                    break;
                case EnumType.Thirteen:
                    break;
                default:
                    return false;
            }
        }

        private void NewLine() { Console.WriteLine(); }

        private bool Show(EventList eventList)
        {
            foreach (var list in eventList)
            {
                Console.BackgroundColor = list.Color;
                Console.WriteLine(list);
            }
            Console.ReadKey();
            return true;
        }

        private bool Show(ReminderList reminderList)
        {
            foreach (var list in reminderList)
            {
                Console.BackgroundColor = list.Color;
                Console.WriteLine(list);
            }
            Console.ReadKey();
            return true;
        }

        private bool Show(TaskList taskList)
        {
            foreach (var list in taskList)
            {
                Console.BackgroundColor = list.Color;
                Console.WriteLine(list);
            }
            Console.ReadKey();
            return true;
        }

        private bool Create(EventList eventList)
        {
            var toDoList = new ToDoList();
            
            eventList.Create(CreateList(toDoList));
            return true;
        }

        private bool Create(ReminderList reminderList)
        {
            var toDoList = new ToDoList();

            reminderList.Create(CreateList(toDoList));
            return true;
        }

        private bool Create(TaskList taskList)
        {
            var toDoList = new ToDoList();

            taskList.Create(CreateList(toDoList));
            return true;
        }

        private ToDoList CreateList(ToDoList toDoList)
        {
            Console.WriteLine($"Enter contact name: ");
            toDoList.Name = Console.ReadLine();

            Console.WriteLine($"Enter data: ");
            toDoList.DateTime = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter color: ");
            var color = Console.ReadLine().ToLower();
            var colorUpper = color.ToUpper();
            color = colorUpper[0] + color[1..];
            
            toDoList.Color = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), color);

            return toDoList;
        }

        private ConsoleColor Color(ConsoleColor color)
        {
            ConsoleColor consoleColor = Console.BackgroundColor;
            return color switch
            {
                ConsoleColor.Red => ConsoleColor.Red,
                ConsoleColor.Green => ConsoleColor.Green,
                ConsoleColor.Blue => ConsoleColor.Blue,
                ConsoleColor.Yellow => ConsoleColor.Yellow,
                ConsoleColor.Cyan => ConsoleColor.Cyan,
                ConsoleColor.Gray => ConsoleColor.Gray,
                ConsoleColor.Magenta => ConsoleColor.Magenta,
                _ => ConsoleColor.Black,
            };
        }
    }
}

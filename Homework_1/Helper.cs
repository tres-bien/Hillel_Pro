using Homework_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal struct Helper
    {
        public static void Run()
        {
            var doingsList = new DoingsList();

            var reminder = new ReminderList(doingsList);

            reminder.Create(new ToDoList
            {
                Name = "Eat",
                Day = 1,
                Month = 1,
                Year = 2000,
            });

            reminder.ShowAll();

            var eventlist = new EventList(doingsList);
            var task = new TaskList(doingsList);
            task.Create(new ToDoList { Name = "Work", Day = 1, Month = 1, Year = 3000 });

            task.ShowAll();
        }
    }
}

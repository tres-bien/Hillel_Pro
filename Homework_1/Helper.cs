using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal struct Helper
    {
        public static void Run()
        {
            //var doingsList = new DoingsList();
            var fileProcessor = new FileProcessor();
            fileProcessor.Get();

            var reminder = new ReminderList(fileProcessor);
            var eventlist = new EventList(fileProcessor);
            var task = new TaskList(fileProcessor);
            reminder.SaveEvent += fileProcessor.Save;
            eventlist.SaveEvent += fileProcessor.Save;
            task.SaveEvent += fileProcessor.Save;

            var meny = new Meny();
            meny.Run(eventlist, reminder, task);
        }
    }
}

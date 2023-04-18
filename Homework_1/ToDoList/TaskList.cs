using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class TaskList : BaseToDoList, ISaveable
    {
        public TaskList(IDoingsList list) : base(list)
        {
        }

        public event SaveDelegate SaveEvent;

        public override void Create(IToDoList task)
        {
            base.Create(task);
            SaveEvent.Invoke(_doings);
        }

        public override void Update(IToDoList task)
        {
            base.Update(task);
            SaveEvent.Invoke(_doings);
        }

        public override void Delete(int id)
        {
            base.Delete(id);
            SaveEvent.Invoke(_doings);
        }

        public override IToDoList GetById(int id)
        {
            return base.GetById(id);
        }

        public override void ShowAll()
        {
            base.ShowAll();
        }

        public void TaskCompleted(bool markACompleted)
        {
            if (markACompleted)
            {
                Console.Write("✅");
            }
            else
            {
                Console.Write("❎");
            }
        }
    }
}

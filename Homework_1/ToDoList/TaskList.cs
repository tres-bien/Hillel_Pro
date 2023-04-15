using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class TaskList : BaseToDoList
    {
        public TaskList(IDoingsList list) : base(list)
        {
        }

        public override void Create(IToDoList task)
        {
            base.Create(task);
        }

        public override void Update(IToDoList task)
        {
            base.Update(task);
        }

        public override void Delete(int id)
        {
            base.Delete(id);
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

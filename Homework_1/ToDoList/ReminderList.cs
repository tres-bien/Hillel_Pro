using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class ReminderList : BaseToDoList
    {
        public ReminderList(IDoingsList list) : base(list)
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
    }
}

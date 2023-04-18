using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal class EventList : BaseToDoList, ISaveable
    {
        public EventList(IDoingsList list) : base(list)
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
    }
}

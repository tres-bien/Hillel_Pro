using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal abstract class BaseToDoList : IEnumerable<IToDoList>, IDoings
    {
        private readonly IDoingsList _list;
        protected List<IToDoList> _doings;

        public BaseToDoList(IDoingsList list)
        {
            _list = list;
            _doings = _list.Get().ToList();
        }

        public IEnumerator<IToDoList> GetEnumerator()
        {
            return _doings.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public virtual void Create(IToDoList task)
        {
            task.Id = _doings.Count;
            _doings.Add(task);
        }

        public virtual void Delete(int id)
        {
            _doings.Remove(GetById(id));
        }

        public virtual void ShowAll()
        {
            foreach (var task in _doings)
            {
                Console.WriteLine(task);
            }
        }

        public virtual void Update(IToDoList task)
        {
            var newTask = GetById(task.Id);
        }

        public virtual IToDoList GetById(int id)
        {
            foreach (var task in _doings)
            {
                if (task.Id == id)
                {
                    return task;
                }
            }
            return null;
        }
    }
}

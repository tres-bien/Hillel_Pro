using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    internal interface IDoings
    {
        void Create(IToDoList task);
        void Update(IToDoList task);
        void Delete(int id);
        void ShowAll();
        IToDoList GetById(int id);
    }
}

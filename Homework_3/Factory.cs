using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Factory<T> where T : class, new()
    {
        public void Create(T instance)
        {
            instance = new T();
        }
    }
}

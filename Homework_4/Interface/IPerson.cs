﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        byte Age { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriseldaExample
{
    class GriseldaMember : rapper
    {
        string name;
        public GriseldaMember(string name)
        {
            _name = name;
            haveBars = true;
            canSing = false;
        }
    }
}

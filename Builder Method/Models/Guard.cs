﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Method.Models
{
    class Guard
    {
        public Guard(string type)
        {
            Type = type;
        }
        public string Type { get; set; }
    }
}

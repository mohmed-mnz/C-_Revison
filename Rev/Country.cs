﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rev
{
    class Country
    {
        public string ISOCode{ get; set; }
        public string Name{ get; set; }
        public override string ToString()
        {
            return $"{Name} ({ISOCode})";
        }
    }

}

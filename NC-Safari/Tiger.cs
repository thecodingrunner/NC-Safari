﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Tiger : PantheraBigCat, IHunt
    {
        public Tiger(float weight) : base(weight)
        {
        }

        public void Hunt()
        {
            Console.WriteLine("Tiger is hunting on land!");
        }
    }
}

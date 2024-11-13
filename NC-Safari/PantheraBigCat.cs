using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal abstract class PantheraBigCat : Mammal
    {
        protected PantheraBigCat(float weight) : base(weight)
        {
        }

        public sealed override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
        }
    }
}

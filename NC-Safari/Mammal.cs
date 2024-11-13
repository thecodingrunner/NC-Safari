using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Mammal : Animal
    {
        protected Mammal(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();
        }
    }
}

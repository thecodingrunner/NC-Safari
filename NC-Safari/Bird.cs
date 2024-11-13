using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal abstract class Bird : Animal
    {
        protected Bird(float weight) : base(weight)
        {
        }

        public override void MakeSound()
        {
            throw new NotImplementedException();    
        }
    }
}

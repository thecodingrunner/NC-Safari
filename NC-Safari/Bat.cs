using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Bat : Mammal, IHunt, IFly
    {
        public Bat(float weight) : base(weight)
        {
        }


        public void Hunt()
        {
            Console.WriteLine("I'm hunting in the sky");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}

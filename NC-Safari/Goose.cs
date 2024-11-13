using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Goose : Bird, IFly, ISwim
    {
        public Goose(float weight) : base(weight)
        {
        }

        public void Fly()
        {
            Console.WriteLine("I am flying");
        }

        public void Swim()
        {
            Console.WriteLine("I am swimming");
        }
    }
}

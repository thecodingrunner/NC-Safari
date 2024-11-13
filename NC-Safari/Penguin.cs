using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class Penguin : Bird, IHunt, ISwim
    {
        public Penguin(float weight) : base(weight)
        {

        }

        public void Hunt()
        {
        Console.WriteLine("Penguin is hunting in water!");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming!");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Quack quack?");
        }
    }
}

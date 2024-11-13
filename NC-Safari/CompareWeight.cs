using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class CompareWeight : IComparer<Animal>
    {
        List<Animal> animals = new List<Animal>();

        public bool isAscending;
        public int Compare(Animal x, Animal y)
        {
            if (x.Weight < y.Weight) return -1;
            else if (x.Weight == y.Weight) return 0;
            else return 1;
        }

        public CompareWeight(Animal x, Animal y)
        {
            Compare(x, y);

            if(isAscending)
            {

            }
        }
        public void SortByWeight(bool isAscending)
        {

        }
    }
}

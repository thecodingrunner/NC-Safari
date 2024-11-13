using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class CompareWeight : IComparer<Animal>
    {

        public bool isAscending;
        public int Compare(Animal x, Animal y)
        {
            if (isAscending)
            {
                if (x.Weight < y.Weight) return -1;
                else if (x.Weight == y.Weight) return 0;
                else return 1;
            } else
            {
                if (x.Weight > y.Weight) return -1;
                else if (x.Weight == y.Weight) return 0;
                else return 1;
            }
        }

        public CompareWeight(bool isAscending)
        {
            this.isAscending = isAscending;
        }
    }
}

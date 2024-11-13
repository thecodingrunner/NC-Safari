using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    internal class WeightFormatter : IFormattable
    {
        public Animal Animal;
        public Enum Culture;


        public WeightFormatter(Animal animal, Enum culture)
        {
            Animal = animal;
            Culture = culture;
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return Animal.Weight.ToString(format, formatProvider);
        }
    }
}

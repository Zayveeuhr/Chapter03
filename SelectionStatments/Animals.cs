using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatments
{
    class Animals
    {
        public string? Name;
        public DateTime Born;
        public byte Legs;
    }
    class Cat : Animals // This is a subtype of animal.
    {
        public bool IsDomestic;
    }

    class Spider: Animals
    {
        public bool IsVenomous;
    }

    class Dog: Animals
    {
        public bool IsFat;
    }
}

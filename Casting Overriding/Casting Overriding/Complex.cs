using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Overriding
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public static explicit operator string (Complex complex)
        {
            return $"{complex?.Real ?? 0} + {complex?.Img ?? 0}";
        }
        public static implicit operator int(Complex complex)
        { 
        return complex?.Real??0 ;
        }

    }
}

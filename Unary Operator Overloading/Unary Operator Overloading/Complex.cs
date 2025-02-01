using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }

        public int Img { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }

        public static Complex operator ++(Complex C) 
        {
            return new Complex
            {
                Real = (C?.Real ?? 0) + 1,
                Img = C.Img
            };
        }
    }
}

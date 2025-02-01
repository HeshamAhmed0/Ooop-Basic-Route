using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_Operator
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public static bool operator >(Complex C1 ,Complex C2)
        {
            if (C1?.Real==C2?.Real)
            {
                return C1?.Img>C2?.Img;
            }
            else
            {
               return C1?.Real > C2?.Real;
            }
        }

        public static bool operator <(Complex C1, Complex C2)
        {
            if (C1?.Real == C2?.Real)
            {
                return C1?.Img < C2?.Img;
            }
            else
            {
                return C1?.Real < C2?.Real;
            }
        }

    }
}

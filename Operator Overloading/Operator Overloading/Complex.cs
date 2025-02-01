using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }

        public static Complex operator + (Complex left, Complex right) 
        {
            //Complex result = new Complex()
            //{
            //    Real = left.Real + right.Real,
            //    Img = left.Img + right.Img,

            //};
            //return result;



            // Another Way For New Complex 

            return new Complex
            {
                Real = (left?.Real??0) + (right?.Real ?? 0),
                Img = (left?.Img??0) + (right?.Img??0),
            };

        }
    }
}

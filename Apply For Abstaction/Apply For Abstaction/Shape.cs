using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Abstaction
{
    internal abstract class Shape
    {
        public decimal Dim01 {  get; set; }
        public decimal Dim02 { get; set; }

        public abstract decimal GetShape();

        public abstract decimal Perimiter { get;  }
    }

    class Rectangle : Shape
    {
        public override decimal Perimiter
        {
            get
            {
                return Dim01 + Dim02;
            }
        }

        public override decimal GetShape()
        {
            return Dim01 * Dim02 * 3.14m;
        }
    }
}

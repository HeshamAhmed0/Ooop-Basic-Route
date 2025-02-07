using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Static
{
    internal class Utility
    {
       

        public static int Num1 { get; set; }
        public static int Num2 { get; set; }
        
        public Utility(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public static double GetArea()
        {
            return Num1 * Num2;
        }
    }
}

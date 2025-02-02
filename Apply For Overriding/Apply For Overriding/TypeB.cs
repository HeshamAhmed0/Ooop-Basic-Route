using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Overriding
{
    internal class TypeB :TypeA
    {
        #region Attributes
        private int B;

        #endregion

        #region Constructor
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        #endregion

        // in this Case will deal As dynamic

        public override void MyFun01()
        {
            Console.WriteLine($"This is MyFun01 in Child A = {a} , B = {B} ");
        }





        // in this Case will deal As static
        public new void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 in Child A = {a} , B = {B} ");
        }

    }
}

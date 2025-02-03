using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_App_For_Binding
{
    internal class TypeB :TypeA
    {
        #region Attributes
        public int B { get; set; }
        #endregion

        #region Constructor
        public TypeB(int a,int b):base(a)
        {
            B = b;
        }
        #endregion

        #region Functions
        public override void MyFun01()
        {
            Console.WriteLine($"TypeB : MyFun01 : A = {A} , B = {B}");
        }

        public new void MyFun02()
        {
            Console.WriteLine($"TypeB : MyFun02 : A = {A} , B = {B}");
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_App_For_Binding
{
    internal class TypeC :TypeB
    {
        #region Attributes
        public int C {  get; set; }
        #endregion

        #region Constructor
        public TypeC(int a,int b,int c):base(a,b)
        {
            C= c;
        }
        #endregion

        #region Functions
        public new virtual void MyFun01()
        {
            Console.WriteLine($"TypeC : MyFun01 : A = {A} , B = {B} , C = {C}");
        }

        public new void MyFun02()
        {
            Console.WriteLine($"TypeC : MyFun02 : A = {A} , B = {B} , C = {C}");
        }
        #endregion
    }
}

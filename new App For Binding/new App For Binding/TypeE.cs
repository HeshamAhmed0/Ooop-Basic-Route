using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_App_For_Binding
{
    internal class TypeE : TypeC
    {
        #region Attributes
        public int E {  get; set; }
        #endregion

        #region Constructor
        public TypeE(int a, int b,int c,int e): base(a,b,c)
        {
            E = a;
        }
        #endregion

        #region Functions
        public override void MyFun01()
        {
            Console.WriteLine($"TypeE: MyFun01 : A = {A} , B = {B}, C = {C} , E = {E}");
        }

        public void MyFun02()
        {
            Console.WriteLine($"TypeE : MyFun02 : A = {A} , B = {B} , C = {C} , E = {E}");
        }
        #endregion
    }
}

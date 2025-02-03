using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_App_For_Binding
{
    internal class TypeA
    {
        #region Property
        public int A { get; set; }
        #endregion

        #region Constructor
        public TypeA(int a)
        {
            A= a;
        }
        #endregion

        #region Functions
        public virtual void MyFun01()
        {
            Console.WriteLine($"TypeA : MyFun01 :  A = {A}");
        }
        public void MyFun02()
        {
            Console.WriteLine($"TypeA : MyFun02 : A = {A}");
        }

        #endregion
    }
}

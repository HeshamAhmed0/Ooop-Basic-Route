using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Binding
{
    internal class TypeA
    {
        #region Attributes
        public int A;

        #endregion

        #region Constructor
        public TypeA(int A)
        {
            this.A = A;
        }
        #endregion

        #region Functions
        public virtual void MyFun01()
        {
            Console.WriteLine($"This Is MyFun01 From Parent A = {A}");
        }

        public void MyFun02()
        {
            Console.WriteLine($"This Is MyFun02 From Parent A = {A}");
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Overriding
{
    internal class TypeA
    {
        #region Attributes
        public int a;

        #endregion

        #region Constructor
        public TypeA(int A)
        {
            a = A;
        }
        #endregion

        public virtual void MyFun01()
        {
            Console.WriteLine($"This is MyFun01 Parent and A = {a}");
        }

        public  void MyFun02()
        {
            Console.WriteLine($"This is MyFun02 in Parent A = {a} ");
        }

    }
}

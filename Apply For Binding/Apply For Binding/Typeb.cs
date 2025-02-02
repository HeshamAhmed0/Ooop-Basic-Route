using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Binding
{
    internal class Typeb : TypeA
    {
        #region Attributes
        public int B;
        #endregion

        #region Constructor
        public Typeb(int A ,int B):base(A)
        {
            this.B = B;
        }
        #endregion

        public override void MyFun01()
        {
            Console.WriteLine($"This Is MyFun02 From child A = {A} , B = {B}");    
        }

        public new void MyFun02() 
        {
            Console.WriteLine($"This Is MyFun02 From Child A ={A} , B = {B}");
        }
    }
}

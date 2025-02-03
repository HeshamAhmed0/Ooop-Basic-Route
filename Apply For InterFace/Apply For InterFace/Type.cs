using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_InterFace
{
    internal class Type : IType
    {
        public int MyId {  get; set; }
        public void MyFun()
        {
            Console.WriteLine("MyFun");
        }
        
        

    }
}

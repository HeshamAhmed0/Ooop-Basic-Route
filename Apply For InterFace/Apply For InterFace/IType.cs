using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_InterFace
{
    internal interface IType
    {
        public int MyId { get; set; }

        public void MyFun();

        public void MyFun02()
        {
            Console.WriteLine("This is myFun02");
        }
    }
}

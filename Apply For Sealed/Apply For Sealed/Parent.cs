using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Sealed
{
    internal class Parent
    {
        public virtual void MyFun()
        {
            Console.WriteLine("I am Parent");
        }
    }

    class Child : Parent
    {
        public sealed override void MyFun()
        {
            Console.WriteLine("I am Child");
        }
    }

    class GrandChild:Child
    {
        // Can not override because it sealed
        //public override void MyFun()
        //{
        //    Console.WriteLine("I am GrandChild");
        //}
    }
}

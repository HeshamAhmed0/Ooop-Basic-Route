using Apply_For_InterFace;

namespace Apply_For_InterFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IType type=new Type();
            type.MyFun();
            type.MyId = 10;
            type.MyFun02();


            Type type2 = new Type();
            type2.MyId = 20;
            type2.MyFun();
            

        }
    }
}

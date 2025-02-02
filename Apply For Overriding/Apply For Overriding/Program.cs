namespace Apply_For_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA TA=new TypeA(5);
            TA.MyFun01();
            TA.MyFun02();

            TypeB t=new TypeB(1,2);
            t.MyFun01();
            t.MyFun02();
        }
    }
}

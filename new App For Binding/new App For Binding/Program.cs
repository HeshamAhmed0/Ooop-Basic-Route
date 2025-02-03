namespace new_App_For_Binding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // will call MyFun01 of => B
            //will Call MyFun02 of => A
            TypeA typeAobj =new TypeE(1,2,3,4);
            typeAobj.MyFun01();
            typeAobj.MyFun02();



            // will call MyFun01 of => B
            //will Call MyFun02 of => B
            TypeB typeBobj =new TypeE(1,2,3,4);
            typeBobj.MyFun01();
            typeBobj.MyFun02();



            // will call MyFun01 of => E
            //will Call MyFun02 of => C
            TypeC typeCobj =new TypeE(1,2,3,4);
            typeCobj.MyFun01();
            typeCobj.MyFun02();



            // will call MyFun01 of => E
            //will Call MyFun02 of => E
            TypeE typeEobj =new TypeE(1,2,3,4);
            typeEobj.MyFun01();
            typeEobj.MyFun02();
        }
    }
}

namespace Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1=new Complex();
            // will initialize the default value 
            C1.Real = 10;
            C1.Img = 5;
            // will initialize Real =10 and Img =5
            Console.WriteLine(C1);

            // will make the same steps
            Complex C2=new Complex();
            C2.Real = 10;
            C2.Img = 5;
            Console.WriteLine(C2);


            Complex C3=new Complex();
            C3 = C1 + C2;
            Console.WriteLine(C3);

        }
    }
}

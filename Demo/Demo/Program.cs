namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Points P1;
            // CLR Will Allocate 8 un initialized bytes in stack with garpage 
            P1= new Points();
            // CLR Will Call Parameter Less Conestactor And Make X=0 And Y=0
            P1 = new(100);
            Console.WriteLine(P1.y);
            Console.WriteLine(P1);
            //will Call Object And Object Will Call WriteLine And WriteLine Will Call ToString
            Console.WriteLine(P1.ToString);
        }
    }
}

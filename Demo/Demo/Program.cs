using System.Runtime.Serialization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLR Will Allocate 8 un initialized bytes in stack with garpage 
            Points P1;
            P1= new Points();
            P1 = new(100);

            // CLR Will Call Parameter Less Conestactor And Make X=0 And Y=0
            //Console.WriteLine(P1.y);
            //Console.WriteLine(P1);
            //will Call Object And Object Will Call WriteLine And WriteLine Will Call ToString
            //Console.WriteLine(P1.ToString);
            Points P2;
            P2= new Points();
            P2 = new(200);

            Console.WriteLine(P2);
            Console.WriteLine(P1);

            P2 = P1;

            Console.WriteLine(P2);
            Console.WriteLine(P1);

            P1.y = 100;
            P1.y = 200;

            Console.WriteLine(P2);
            Console.WriteLine(P1);
        }
    }
}

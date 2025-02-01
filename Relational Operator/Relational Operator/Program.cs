namespace Relational_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1= new Complex();
            Complex c2= new Complex();
            c1.Real = 10;
            c2.Real = 20;
            c1.Img = 5;
            c2.Img = 6;
            string message = c1 > c2 ? "C1 > C2 " : "C1 < C2";
            Console.WriteLine(message);
        }
    }
}

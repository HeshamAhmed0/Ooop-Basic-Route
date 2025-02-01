namespace Unary_Operator_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
Complex complex = new Complex();
            complex.Real = 10;
            complex.Img = 5;
            Console.WriteLine(complex++);
            Console.WriteLine(++complex);

        }
    }
}

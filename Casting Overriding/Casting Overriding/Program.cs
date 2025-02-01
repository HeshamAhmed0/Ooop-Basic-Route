namespace Casting_Overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
Complex C1 = new Complex();
            int x = C1;
            Console.WriteLine(x);    // will return default value => 0
            C1.Real = 10;
            x= C1;
            Console.WriteLine(x);    // will return Real Part => 10
        }
    }
}

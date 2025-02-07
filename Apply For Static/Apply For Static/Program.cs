namespace Apply_For_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //before Make Method Static
            //Utility U = new Utility(10,20);
            //Console.WriteLine($"Area Is {U.GetArea()}");

            //After Make method Static
            Utility.Num1 = 10;
            Console.WriteLine($"Area Is {Utility.GetArea()}");

        }
    }
}

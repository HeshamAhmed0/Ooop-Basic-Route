namespace Apply_For_Abstaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle() { Dim01 = 10, Dim02 = 10, };
            Console.WriteLine($"RECTANGLE P = {rectangle.Perimiter}");
            Console.WriteLine($"RECTANGLE AREA ={rectangle.GetShape()}");

        }
    }
}

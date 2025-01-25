namespace Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex.1
            Human01 h = new Human01();
            h = Human01.Female;
            Console.WriteLine(h);
            h = (Human01)2;
            Console.WriteLine(h); 
            #endregion
        }
    }
}

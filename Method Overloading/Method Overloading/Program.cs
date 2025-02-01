namespace Method_Overloading
{
    internal class Program
    {
        static int SumNums(int A,int B)
        { 
        return A + B;
        }
        static double SumNums(double A,double B)
        {
            return (A + B);
        }
        static double  SumNums(int A,double B)
        {
            return (A + B);
        }
        static double SumNums(double A,int B)
        {
            return A + B;
        }
        static int SumNums(int A,int B ,int C)
        {
            return A + B + C;   
        }
        static void Main(string[] args)
        {
            // in this case will call function that take two integer 
           double Result= SumNums(1,2);
            Console.WriteLine( Result);

            // in this case will call function that take int and double 
            Result = SumNums(1,3.50);
            Console.WriteLine(Result);

        }
    }
}

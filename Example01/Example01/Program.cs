namespace Example01
{
    internal class Program
    {
        public static void GetDetails(ISeries ISeriesObj)
        {
            if (ISeriesObj is not null)
            {
                for (int i=1;i<=5;i++)
                {
                    Console.WriteLine(ISeriesObj.Current);
                    ISeriesObj.GetNext();
                }
                ISeriesObj.Reset();
            }
        }
        static void Main(string[] args)
        {
        TypeB typeAObj =new TypeB();
            GetDetails(typeAObj);

        }
    }
}

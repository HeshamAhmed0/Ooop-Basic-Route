namespace Assign_S1_N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Season Name : ");
            string input=Console.ReadLine();
            Season SeasionName;  Enum.TryParse(input, true, out SeasionName);
            if (SeasionName == Season.Spring)
            {
                Console.WriteLine("Spring: March to May");
            } else if (SeasionName==Season.Winter)
            {
                Console.WriteLine("Winter: December to February");

            }
            else if (SeasionName == Season.Autumn)
            {
                Console.WriteLine("Autumn: September to November");

            }
            else if(SeasionName == Season.Summer)
            {
                Console.WriteLine("Summer: June to August");

            }
            else
            {
                Console.WriteLine("Invalid season.");

            }



        }
    }
}

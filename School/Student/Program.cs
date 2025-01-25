namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StDetails stDetails = new StDetails();
            bool IsParsed;
            int StId;
            do
            {
                Console.Write("Enter Your Id : ");
                IsParsed = int.TryParse(Console.ReadLine(), out StId);
            } while (!IsParsed);
            stDetails.Id = StId;
            Console.Clear();


            string Name;
            do
            {
                Console.Write("Enter Your Name : ");
                 Name = Console.ReadLine();
                if (string.IsNullOrEmpty(Name) || !Name.All(char.IsLetter))
                {
                    Console.Write("Enter Valid Name : ");
                    Name = Console.ReadLine();
                }

            } while (!IsParsed);
            stDetails.Name = Name;
            Console.Clear();



            Gender Gend;
            do
            {
                Console.Write("Enter Your Gender : ");
                IsParsed = Enum.TryParse<Gender>(Console.ReadLine(), out Gend);
            } while (!IsParsed);
            stDetails.Gender= Gend;
            Console.Clear();



            Branch branch;
            do
            {
                Console.Write("Enter Your Branch : ");
                IsParsed =Enum.TryParse<Branch>(Console.ReadLine(),out branch);
            } while (!IsParsed);
            stDetails.Branch= branch;
            Console.Clear();

            Console.WriteLine($"Hello {stDetails.Name} \n Your Branch is {stDetails.Branch}");
        }
    }
}

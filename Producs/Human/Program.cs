namespace Human
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ex.1
            //Human01 h = new Human01();
            //h = Human01.Female;
            //Console.WriteLine(h);
            //h = (Human01)2;
            //Console.WriteLine(h); 
            #endregion

            #region Ex.2
            //Details humans = new Details();
            //humans.Id = 1;
            //humans.Name= "hesham";
            //humans.Branches=Branches.Cairo;
            //humans.gender = Gender.male;


            #endregion

            #region Ex.3
            bool isParsed;
            int StId;
            Details stu02=new Details();
            do
            {
                Console.Write("Enter Id : ");
                isParsed = int.TryParse(Console.ReadLine(), out StId);
            } while (!isParsed);
            StId= stu02.Id;
           
           
            
            Console.Write("Enter Name : ");
            string Name=Console.ReadLine();
            while (string.IsNullOrEmpty(Name) || !Name.All(char.IsLetter))
            {
                Console.Write("Enter Valid Name : ");
                Name = Console.ReadLine();
            }
            stu02.Name = Name;



            object Gend;
            do
            {
                Console.Write("Enter Gender : ");
               isParsed = Enum.TryParse(typeof(Gender),Console.ReadLine(),out Gend );

            } while (!isParsed|| Gend is null);
            stu02.gender =(Gender) Gend;



            Branches Branch;
            do
            {
                Console.Write("Enter Branch : ");
              isParsed=  Enum.TryParse<Branches>(Console.ReadLine(),out Branch );
            } while (!isParsed);
            stu02.Branches=Branch;

            Console.WriteLine($"Hello {stu02.Name} ");
            #endregion
        }
    }
}

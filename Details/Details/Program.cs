namespace Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentsProperty std01= new StudentsProperty();
            bool IsParsed;
            Gender Gend;
            do
            {
                Console.WriteLine("Enter Geder : ");
                IsParsed = Enum.TryParse<Gender>(Console.ReadLine(),out Gend);
            } while (!IsParsed);
            std01.Gender= Gend;
            Console.WriteLine(std01.Gender);
        }
    }
}

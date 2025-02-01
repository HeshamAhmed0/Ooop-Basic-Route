namespace User_Define_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DataBase will take User And I Will Make User Call ViewUser
            User user1 = new User()
            {
                Id = 1,
                FullName = "Hesham Ahmed",
                Email = "HeshamMathanagmail.com",
                Guid = Guid.NewGuid(),
            };


            ViewUser viewUser = (ViewUser)user1;

            Console.WriteLine(viewUser);
        }
    }
}

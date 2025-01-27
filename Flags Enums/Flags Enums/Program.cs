namespace Flags_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Flags Enum
            Human humans = new Human();
            //humans.Id = 1;
            //humans.Name = "test";
            //humans.Properties = Properties.Delete;
            humans.Permisions = (Permisions)3;
            //Console.WriteLine(humans.Properties);
            //humans.Properties = humans.Properties ^ Properties.read;
            //Console.WriteLine(humans.Properties); 

            // Check for permission
            if ((humans.Permisions & Permisions.Read) == Permisions.Read)
            {
                Console.WriteLine("This Human Has Read Permission ");
            }
            else
            {
                Console.WriteLine("This Human Not Has Read Property");
                humans.Permisions ^= Permisions.Read;
                Console.WriteLine("Operation Add Property Read Done Succcesful");
                Console.WriteLine(humans.Permisions);

            }
            #endregion
        }
    }
}

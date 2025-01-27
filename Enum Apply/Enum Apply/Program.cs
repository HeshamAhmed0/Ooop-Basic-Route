namespace Enum_Apply
{
    internal class Program
    {
        static void Main(string[] args)
        {
Human Hu01= new Human();
            Hu01.Name = "Hesham";
            Hu01.Id= 1;
            Hu01.Permition = (Permition)12;
            Hu01.Permition ^= Permition.Write; // in this step  The Permission Witr Added 
            Console.WriteLine(Hu01.Permition);
            Hu01.Permition ^= Permition.Execute;// in this Step The Permision Execute Was Remve
            Console.WriteLine(Hu01.Permition);
            if ((Hu01.Permition&Permition.Write)==Permition.Write)
            {
                Hu01.Permition ^= Permition.Execute;
                Console.WriteLine(Hu01.Permition);
            }
        }
    }
}

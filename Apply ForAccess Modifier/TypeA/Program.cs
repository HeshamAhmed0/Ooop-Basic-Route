namespace TypeA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ttype type1=new ttype();
            //type1.A = 50;// invalid[private]
            //type1.B = 20;// valid internal => in the same Project 
            //type1.C = 30;// valid public in any place 
            //type1.D = 50;// in valid No inheritace deal with it as private 
            //type1.E = 50;// Valid deal with it As internal  
            //type1.F = 50;// in valid No inheritace deal with it as private 

               
        }
    }
}

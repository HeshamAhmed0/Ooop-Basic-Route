using System.Text;

namespace Shallow_Copy_And_deep_Copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Shallow Copy And Reference Copy Value Type
            #region Shallow Copy
            //int[] Arr01 = { 1, 2, 3, };
            //int[] Arr02 = new int[2];
            //Arr02 = Arr01;
            // In This Case i Make Shallo Coppy 
            // i take instance of Arr01 and make it in insTANCE aRR02
            #endregion

            #region Deep Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = new int[3];
            //Arr02 = (int[])Arr01.Clone();
            //// in this case Deep Copy Happen
            // this will take copy from values of Arr02 And Make New instance and make it in the new instance 
            //after that will make the reference share to that 
            #endregion
            #endregion

            #region Shallow Copy And Deep Copy Reference Type

            #region Immutable
            //string[] Arr01 = { "hesham", "Ahmed" };
            //string[] Arr02 = new string[2];
            //// Shallo Copy
            //Arr02 = Arr01; =>>>> Shallow Copy


            //Arr02 = (string[])Arr01.Clone(); =>>>>>>  Deep Copy



            #endregion

            #region Mutable

            //StringBuilder[] Arr01 = [new StringBuilder("Hesham")];
            //StringBuilder[] Arr02 = new StringBuilder[1];

            // Shallo Copy 
            //What Will happen 
            // The Reference of Two Array Will Refere to the same reference
            //Arr02 = Arr01;


            // Deep Copy 
            //Arr02 = (StringBuilder[])Arr01.Clone();
            // in tis case the two object will refere to the same object 





            #endregion

            #endregion
        }
    }
}

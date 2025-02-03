using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Polymorphism
{
    internal class PartTimeEmployee :Employee
    {
        #region Properties
        public int hours {  get; set; }
        #endregion

        #region Constructor
        public PartTimeEmployee(int Id ,string? Name,int Age,int Hours):base(Id,Name,Age)
        {
            hours=Hours;
        }
        #endregion

        #region Functions
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($" , Hours {hours}");
        }

        
        #endregion
    }
}

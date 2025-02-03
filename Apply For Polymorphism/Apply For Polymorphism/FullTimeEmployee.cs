using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Polymorphism
{
    internal class FullTimeEmployee : Employee
    {
       
        #region Property
        public decimal Salary { get; set; }
        #endregion


        #region Constructor
        public FullTimeEmployee(int id, string? name, int age,decimal salary) : base(id, name, age)
        {
            Salary = salary;
        }
        #endregion


        #region Functions
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine($" , Salary = {Salary}");
        }

        public new void GetType()
        {
            Console.WriteLine("I am FullTime Employee");
        }
        #endregion

    }
}

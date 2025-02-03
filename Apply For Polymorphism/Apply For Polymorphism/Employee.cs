using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Polymorphism
{
    internal class Employee
    {
        
        #region Attributes
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        #endregion

        #region Constructor
public Employee(int id, string? name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        #endregion

        #region Functions
        public  void GetType()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void GetDetails()
        {
            Console.Write($"Id = {Id} , Name = {Name} , Age = {Age}");
        }
        #endregion
    }
}

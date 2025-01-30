using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplyForChaining
{
    internal class Person
    {
        #region Attributes
        private int id;
        private string? name;
        public int Age;


        #endregion

        #region Constructor
        public Person(int id, string? name, int Age)
        {
            this.id = id;
            this.name = name;
            this.Age = Age;
        }
        public Person(int Age) : this(10, "Hesham", Age) { }
        public Person(int Age, string Name) : this(20, Name, Age) { }
        #endregion

        public override string ToString()
        {
            return $" Id : {id} , Name : {name} , Age : {Age}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shallow_Copy_And_deep_Copy
{
    internal class Employee: ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public object Clone()
        {
            return new Employee
            {
                Id = Id,
                Name = Name,
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Details
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public Gender gender { get; set; }

        public Branches Branches { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class TypeA : ISeries
    {
        public int Current {  get; set; }
        public void GetNext()
        {
            Current++;
        }

    }
}

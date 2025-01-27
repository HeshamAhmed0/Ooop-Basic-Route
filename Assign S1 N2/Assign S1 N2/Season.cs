using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_S1_N2
{
    [Flags]
    internal enum Season
    {
        none=0,
        Spring=1,
        Summer=2,
        Autumn=4, 
        Winter=8,
    }
}

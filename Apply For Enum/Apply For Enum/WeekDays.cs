using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apply_For_Enum
{
    [Flags]
     enum WeekDays
    {
        Monday=1, 
        Tuesday=2,
        Wednesday=4,
        Thursday=8, 
        Friday=16,
        Saturdey=32,
        Sunday=64,
    }
}

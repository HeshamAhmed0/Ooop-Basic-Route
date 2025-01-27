using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_S1_N2
{
    [Flags]
    internal enum Manths
    {
        January=1,
        February=2,
        March=4,
        April=8,
        May=16,
        June=32,
        July=64,
        August=128,
        September=256,
        October=512,
        November=1024,
        December=2048,
    }
}

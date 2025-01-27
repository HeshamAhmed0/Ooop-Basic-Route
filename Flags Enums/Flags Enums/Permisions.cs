using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flags_Enums
{
    [Flags]
    internal enum Permisions : byte
    {
        Write=1,
        Delete =2,
        Read =4,
    }
}

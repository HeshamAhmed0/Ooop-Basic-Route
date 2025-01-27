using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flags_Enums
{
    internal enum Permisions : byte
    {
        None = 0,
        Write=1,
        Delete =2,
        Read =4,
    }
}

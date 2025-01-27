using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal struct Points
    {
        #region Attributes
        public int x;
        public int y;
        #endregion

        #region Constractors
        public Points()
        {
            x = 10;
            y = 10;
        }
        public Points(int x, int y) { 
        this.x = x;
            this.y = y;
        }
        public Points(int Number)
        {
            this.x = Number;
            this.y = Number;
        }

        public override string ToString()
        {
            return $"{x},{y}";
        }

        #endregion

    }
}

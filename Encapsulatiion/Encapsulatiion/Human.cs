using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulatiion
{
    internal struct Human
    {
        #region Attriputes
        private int Id;
        private string? EmName;
        #endregion

        #region Getter And Setter 
        //public string? GetName()
        //{
        //    return EmName;
        //}

        //public void SetName(String? name)
        //{
        //    EmName = name?.Length > 10 ? name.Substring(0, 10) : name;
        //} 
        #endregion


        #region Property
        public int EmId
        {
            get { return Id; }
            set { Id = value < 200 ? 200 : value; }
        }
        #endregion


    }
}

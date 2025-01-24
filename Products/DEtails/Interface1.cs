using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEtails
{
    internal interface Interface1
    {
        void ReturnName(string name);// signeture by method
        public int Age {  get; set; } //signeture by property
        void ReturnDescription(string description)// default implementation method
        {
            Console.WriteLine($"Hello {description}");
        }
    }
}

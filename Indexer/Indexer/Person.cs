using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal struct Person
    {
        #region Attributes
        private int size;
        private string[]? names;
        private int[]? numbers;
        private int index;

        #endregion

        #region Constructor
        public Person(int SiZe )
        {
            size = SiZe;
            names = new string[size];
            numbers = new int[size];
        }

        public void AddNewPerson(int Position ,String Name,int Number )
        {
            if (numbers is not null&& names is not null)
            {
                if (Position>=0&&Position<size)
                {
                    names[Position] = Name;
                    numbers[Position] = Number;
                }
            }
        }

        public int GetNumberOfPerson(string Name)
        {
            foreach (string item in names)
            {
                if (Name==item)
                {
                    index = names.Index(item);
                }
            }
            return numbers[index];
        }
        #endregion
    }
}

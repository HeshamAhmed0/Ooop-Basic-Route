using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans
{
    internal struct Person
    {
        #region Attributes
        private string[]? name=new string[3];
        private int[]? id=new int[3];
        private int[] position =new int[3];
        private int CurrentPosition;
        private int Choosen;
        private string inputSTRING;
        private int inputINT;
        #endregion
        public Person()
        {
            Console.Write("Enter Position : ");
            int Position; int.TryParse(Console.ReadLine(),out Position);
            if (Position==0)
            {
                Console.Write("Enter Valid Position : ");

            }
            else
            {
                CurrentPosition = Position;

            }
            Console.WriteLine("Choose What Do You Want : ");
            Console.WriteLine(" 1    Get Name ");
            Console.WriteLine(" 2    Set Name");
            Console.WriteLine(" 3    Get Id");
            Console.WriteLine(" 4    Set Id");
            int.TryParse(Console.ReadLine(),out Choosen);
            if (Choosen == 0)
            {
                Console.Write("In Valid Choosen Please Enter Valid Choosen : ");
            }
            else if (Choosen == 1)
            {

                GetName();
            }
            else if (Choosen == 2)
            {
                Console.Write("Enter Person You Wwant TO Set : ");
                inputSTRING = Console.ReadLine();
                SetName(inputSTRING);
            }
            else if (Choosen == 3)
            {
                GetId();
            }
            else if (Choosen == 4) {
                Console.Write("Enter ID : ");
                int.TryParse(Console.ReadLine(),out inputINT);
                SetId(inputINT);  
            }
        }
        #region Methods
        public string GetName()
        {
            if (name is not null )
            {
                return $"Name : {name[CurrentPosition - 1]} ";
            }
            return "There Aren't this Name And Id ";
        }
        public void SetName(string Name)
        {
            if (name[CurrentPosition-1] is not null)
            {
                Console.WriteLine("Ther Are No Size To Add new Person");
            }else
            {
                name[CurrentPosition-1]=Name;
            }
        }
        public void GetId()
        {
            if(id[CurrentPosition-1] !=0)
            {
                Console.WriteLine($"Id : {id[CurrentPosition - 1]}");
            }else
            {
                Console.WriteLine("In Valid Position ");
            }
        }
        public void SetId(int Id)
        {
            if (id[CurrentPosition]==0| id is null)
            {

                id[CurrentPosition-1] = Id;
            }
            else
            {
                Console.WriteLine("In valid Position ");
            }
        }
        #endregion



        

    }
}

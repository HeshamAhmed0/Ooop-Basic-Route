using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Define_Casting
{
    internal class ViewUser
    {
        public int Id { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Email { get; set; }

        public static explicit operator ViewUser(User user)
        {
            string[]? NameParts = user?.FullName?.Split(" ");

            return new ViewUser()
            {
            Id = user?.Id??0,
            Fname= NameParts?[0] ,
            Lname =NameParts.Length>1 ? NameParts[1] : null ,
            Email = user.Email,
            };
        }

        public override string ToString()
        {
            return $"Id : {Id}  Fname : {Fname}  Lname : {Lname}  Email : {Email}";
        }
    }
}

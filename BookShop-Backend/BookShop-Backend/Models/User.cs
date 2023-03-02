using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop_Backend.Models
{
    public class User
    {
        public int UserId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Mobile { get; set; }
        public String Gender { get; set; }
        public String Pwd { get; set; }
        public DateTime MemberSince { get; set; }



    }
}

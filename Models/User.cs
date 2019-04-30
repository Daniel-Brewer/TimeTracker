using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class User: IdentityUser 
    {
        public User()
        {
        }

     /*   public int Id{ get; set; } */
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<UserCategory> UserCategories { get; set; }
    }
}

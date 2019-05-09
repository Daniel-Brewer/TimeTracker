using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UserId { get; set; }
        //public DateTime DatePicked { get; set; }
        public User User { get; set; }
        public ICollection<UserCategory> UserCategories { get; set; }
    }
}

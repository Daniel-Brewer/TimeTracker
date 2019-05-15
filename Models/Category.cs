using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Category:")]
        public string Title { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public ICollection<UserCategory> UserCategories { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.UserCategoriesViewModels
{
    public class UserCategoriesIndexViewModel
    {
        public List<UserCategory> UserCategories { get; set; }
        public DateTime MinutesSpent { get; set; }
        public DateTime DatePicked { get; set; }
        public User User { get; set; }
    }
}

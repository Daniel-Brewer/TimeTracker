using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.UserCategoriesViewModels
{
    public class UserCategoriesIndexViewModel
    {
        public List<UserCategory> UserCategories { get; set; }
        public DateTime MinutesSpent { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DatePicked:")]
        public DateTime DatePicked { get; set; }
        public User User { get; set; }
    }
}

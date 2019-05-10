using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.CategoriesViewModels
{
    public class CategoriesIndexViewModel
    {
        [Required]
        public Category Category { get; set; }
        [Required]
        public UserCategory UserCategory { get; set; }
        [Required]
        public List<Category> Categories { get; set; }
        [Required]
        public List<UserCategory> UserCategories { get; set; }
        [Required]
        public int MinutesSpent { get; set; }
        [Required]
        public List<int> MinutesSpentList { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DatePicked:")]
        public DateTime DatePicked { get; set; }
    }
}

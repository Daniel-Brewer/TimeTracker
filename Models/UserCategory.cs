using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TimeTracker.Models
{
    public class UserCategory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int MinutesSpent { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "DatePicked:")]
        public DateTime DatePicked { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}

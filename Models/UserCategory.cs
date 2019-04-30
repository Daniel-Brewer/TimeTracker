﻿using System;
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
        public DateTime MinutesSpent { get; set; }
        [Required]
        public DateTime DatePicked { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}

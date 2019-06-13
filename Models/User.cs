﻿using Microsoft.AspNetCore.Identity;
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

        public ICollection<UserCategory> UserCategories { get; set; }
    }
}

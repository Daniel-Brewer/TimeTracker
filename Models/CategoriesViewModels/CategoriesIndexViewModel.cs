using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.CategoriesViewModels
{
    public class CategoriesIndexViewModel
    {
        public Category Category { get; set; }
        public UserCategory UserCategory { get; set; }
        public List<Category> Categories { get; set; }
    }
}

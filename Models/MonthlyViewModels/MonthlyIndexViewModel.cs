using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.MonthlyViewModels
{
    public class MonthlyIndexViewModel
    {
        public IEnumerable<SelectListItem> Months => DateTimeFormatInfo
                       .InvariantInfo
                       .MonthNames
                       .Where(m => !string.IsNullOrEmpty(m))
                       .Select((monthName, index) => new SelectListItem
                       {
                           Value = (index + 1).ToString(),
                           Text = monthName
                       });
        public int MonthId { get; set; }

        public int YearId { get; set; }
        public IEnumerable <SelectListItem> Years = new SelectList(Enumerable.Range(2018, (DateTime.Now.Year - 2018) + 1));
    }

   
    
   
}


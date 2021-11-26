using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LMS1.Models
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        [Display(Name = "ISBN")]
        public string ISBN { get; set; }

        public string Author { get; set; }
        public string Publisher { get; set; }
        public bool IsAvailable { get; set; }
    }
}
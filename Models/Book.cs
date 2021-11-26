using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LMS1.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string BookCategory { get; set; }

        [Required]
        public string ISBN { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }
        public ICollection<BorrowHistory> BorrowHistories { get; set; }
    }
}
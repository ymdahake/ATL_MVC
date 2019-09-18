using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATL.Models.ViewModels
{
    public class UserBookSubscriptionViewModel
    {
        [Required]
        public int BookId { get; set; }
        [Required]
        public DateTime FromDate { get; set; }
        [Required]
        public DateTime ToDate { get; set; }
   
    }
}
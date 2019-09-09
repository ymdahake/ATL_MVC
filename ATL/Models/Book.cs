using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATL.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        public string SubTitle { get; set; }

        [Required]
        public string Authors { get; set; }

        [Required]
        [StringLength(250)]
        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int AverageRating { get; set; }

        public string Thumbnail { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public string ISBN { get; set; }

        [Required]
        [DisplayName("No Of Copies")]
        public int NoOfCopiesAvailable { get; set; }

        public virtual Category Category { get; set; }
        

    }



}
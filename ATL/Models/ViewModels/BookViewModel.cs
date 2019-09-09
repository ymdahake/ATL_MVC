using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATL.Models.ViewModels
{
    public class BookViewModel
    {

        public Book Book { get; set; }
        public Category Category { get; set; }
        public List<Category> Categories { get; set; }
    }
}
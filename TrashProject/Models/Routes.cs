using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashProject.Models
{
    public class Routes
    {
        public int Id { get; set; }

        [Display(Name = "What zip code would you like to look up?")]
        public string Zipcode { get; set; }

        

        
    }

}
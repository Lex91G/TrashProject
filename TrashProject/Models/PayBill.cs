using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashProject.Models
{
    public class PayBill
    {

        public int Id { get; set; }

        [Display(Name = "How many pick ups would you like to purchase")]
        public string SetPickUps
        {
            get; set;



        }
    }
}

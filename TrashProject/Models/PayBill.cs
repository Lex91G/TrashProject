using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashProject.Models
{
    public class PayBill
    {

        public int Id { get; }

        [Display(Name = "How many pick ups would you like to purchase")]
        public string SetPickUps { get; set; }

        [Display(Name = "Credit Card number")]
        public string CreditCardNumber { get; set; }

        [Display(Name = "Experation Date")]
        public string ExperationDate { get; set; }

        [Display(Name = "CVC")]
        public string CVC { get; set; }

        

    }
}
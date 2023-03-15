using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9.Models
{
    public class Payment
    {
        [Key]
        [BindNever]
        public int PaymentId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter your Name:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required(ErrorMessage = "Please enter City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please Enter Zip Code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please Enter Country")]
        public string Country { get; set; }
    }
}

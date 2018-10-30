using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cornerstone_webapp.Models
{
    public class InspectionRequest
    {
        [DisplayName("I am a")]
        [Required(ErrorMessage = "Please choose an option.")]
        public string CustType { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Please enter name.")]
        public string CustName { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Please enter email.")]
        [EmailAddress(ErrorMessage = "Please enter valid email.")]
        [DataType(DataType.EmailAddress)]
        public string CustEmail { get; set; }

        [DisplayName("Phone number")]
        [Required(ErrorMessage = "Please enter phone number.")]
        [Phone(ErrorMessage = "Please enter your phone number.")]
        [RegularExpression(@"^[0-9]{0,15}$", ErrorMessage = "Phone number should contain only numbers")]
        [DataType(DataType.PhoneNumber)]
        public string CustPhone { get; set; }

        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [ReadOnly(true)]
        public bool? IsSubmitted { get; set; }
    }
}
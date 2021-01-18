using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace catalogv6.Models
{
    public class Contact
    {
        [Key]
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

        [PhoneNumberValidation]
        public string PhoneNumber { get; set; }

        [EmailValidation]
        public string Email { get; set; }

        // one-to-one relationship
        public virtual Teacher Teacher { get; set; }
    }
}
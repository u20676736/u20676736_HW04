using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace u20676736_HW04.Models
{
    public class PATHAccount
    {
        public int UserID { get; set; }
        [Required(ErrorMessage ="Please Enter your UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter your Password")]
        public string Passwaord { get; set; }
    }
}
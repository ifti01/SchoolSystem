using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolSystem.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Required")] 
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Required")]
        [MinLength(11,ErrorMessage = "Number must be 11 digit")]
        public string MobileNo { get; set; }
        public string Description { get; set; }
    }
}
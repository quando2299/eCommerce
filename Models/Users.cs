using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutDemo.Models
{
    public class Users
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Not null")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Not null")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Not null")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Not null")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Not null")]
        public string ConfirmPassword { get; set; }

        public string  CreateUser { get; set; }

        public DateTime CreateDate { get; set; }

        public string EditUser { get; set; }

        public DateTime EditDate { get; set; }

        [Required(ErrorMessage = "Not null")]
        public int Status { get; set; }

    }
}

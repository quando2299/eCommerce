using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutDemo.Models
{
    public class Addresses
    {
        public int ID { get; set; }
        
        public Users users { get; set; }

        public int UsersID { get; set; }

        public string Phone { get; set; }

        [Required(ErrorMessage ="Not null")]
        public string Address { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        public string UpdateUser { get; set; }
    }
}

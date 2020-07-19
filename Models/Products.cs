using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutDemo.Models
{
    public class Products
    { 
        public int ID { get; set; }

        [Required(ErrorMessage ="Not null")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Not null")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Not null")]
        public string Image { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        public string UpdateUser { get; set; }

        [Required(ErrorMessage = "Not null")]
        public int Status { get; set; }
    }
}

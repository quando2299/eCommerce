using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutDemo.Models
{
    public class Discounts
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Not null")]
        public string Name { get;set;}


        [Required(ErrorMessage = "Not null")]
        public float discount { get; set; }


        [Required(ErrorMessage = "Not null")]
        public DateTime DateValid { get; set; }


        [Required(ErrorMessage = "Not null")]
        public int Quantity { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        public string UpdateUser { get; set; }


        [Required(ErrorMessage = "Not null")]
        public int Status { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutDemo.Models
{
    public class OrderDetails
    {
        public int ID { get; set; }

        public Products products { get; set; }
        public int ProductID { get; set; }

        public Orders orders { get; set; }

        public int OrdersID { get; set; }

        [Required(ErrorMessage = "Not null")]
        public int Quantity { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        public string UpdateUser { get; set; }

        
        public int Status { get; set; }
    }
}

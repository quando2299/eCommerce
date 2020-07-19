using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutDemo.Models
{
    public class Orders
    {
        public int ID { get; set; }

        public Users users { get; set; }

        public int UsersID { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateUser { get; set; }

        public DateTime UpdateDate { get; set; }

        public string UpdateUser { get; set; }

        public int Total { get; set; }

        public int Status { get; set; }
    }
}

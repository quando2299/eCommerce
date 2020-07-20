using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayoutDemo.Models.ViewModel
{
    public class Cart
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        //public int Total { get; set; }
    }
}

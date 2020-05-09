using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exemple_mvc.Models
{
    public class cart
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public string productimg { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }
        public decimal bill { get; set; }
    }
}
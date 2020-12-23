using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TNTTSHOP.Areas.Admin.Models
{
    public class CartItem
    {
        public int Ma{ get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public decimal DonGia { get; set; }
        public int quantity { get; set; }
        public decimal thanhtien => quantity * DonGia;
    }
}

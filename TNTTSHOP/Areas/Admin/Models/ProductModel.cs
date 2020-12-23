using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TNTTSHOP.Areas.Admin.Models
{
    public class ProductModel
    {
        [Key]
        public int MaPro { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public double quantity { get; set; }
        public decimal price { get; set; }
        public string content { get; set; }
        public int status { get; set; }
        public int Category { get; set; }
        [ForeignKey("Category")]
        public CategoryModel CategoryModel { get; set; }
    }
}

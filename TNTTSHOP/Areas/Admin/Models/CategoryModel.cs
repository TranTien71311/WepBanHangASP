using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TNTTSHOP.Areas.Admin.Models
{
    public class CategoryModel
    {
        [Key]
        public int MaCate { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int status { get; set; }
        public ICollection<ProductModel> sltPro { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TNTTSHOP.Areas.Admin.Models
{
    public class SupplientModel
    {
        [Key]
        public int MaSupp { get; set; }
        public string name { get; set; }
        public string Email { get; set; }
        public string address { get; set; }
        public int status { get; set; }
    }
}

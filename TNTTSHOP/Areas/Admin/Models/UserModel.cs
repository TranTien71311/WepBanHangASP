using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TNTTSHOP.Areas.Admin.Models
{
    public class UserModel
    {
        [Key]
        public int maUser { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int sdt { get; set; }
        public string address { get; set; }
        public string position { get; set; }
        public int status { get; set; }
    }
}

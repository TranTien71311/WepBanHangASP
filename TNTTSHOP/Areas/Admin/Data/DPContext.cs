using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TNTTSHOP.Areas.Admin.Models;

namespace TNTTSHOP.Areas.Admin.Data
{
    public class DPContext:DbContext
    {

        public DPContext(DbContextOptions options):base(options)
        { }
        public DbSet<UserModel> UserModels { get; set; }
        public DbSet<CategoryModel> CategoryModels { get; set; }
        public DbSet<ProductModel> ProductModels { get; set; }
        public DbSet<Areas.Admin.Models.CategoryModel> CategoryModel { get; set; }
        public DbSet<SupplientModel> SupplientModel { get; set; }
    }
}

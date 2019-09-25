using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityDIMVC.Model;

namespace UnityDIMVC.Repository
{
    public class DbconnContext : DbContext
    {
        public DbconnContext() : base("DefaultConnection")
        {

        }
        public virtual DbSet<CategoryVM> categoris { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

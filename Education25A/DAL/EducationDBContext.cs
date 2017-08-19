using Education25A.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Education25A.DAL
{
    public class EducationDBContext : DbContext
    {
        public EducationDBContext(): base("EducationContext")
        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
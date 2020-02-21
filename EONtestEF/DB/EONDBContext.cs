using EONtestEF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EONtestEF.DB
{
    public class EONDbContext : DbContext
    {
        public EONDbContext() : base("Server=DESKTOP-MBSGJ0P; Database=EONtest;Integrated Security=True")
        {
            Database.SetInitializer(new EONDBInitializer<EONDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }

        public DbSet<Users> users { get; set; }
       }
}
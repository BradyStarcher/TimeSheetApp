using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TimeSheetApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        private string connectionString = @"Server=localhost\SQLEXPRESS;database=TimeSheet;MultipleActiveResultSets=true;Trusted_Connection=True;";

        public DbSet<TimeSheetApp.Models.User> Employee { get; set; }
        public DbSet<TimeSheetApp.Models.Manager> Manager { get; set; }
        public DbSet<TimeSheetApp.Models.HR> HR { get; set; }
        public DbSet<TimeSheetApp.Models.Division> Division { get; set; }
        public DbSet<TimeSheetApp.Models.Payroll> Payroll { get; set; }
        public DbSet<TimeSheetApp.Models.TimeClock> TimeClock { get; set; }
    }
}

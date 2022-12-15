using DormitoryManagement.Enitity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DormitoryManagement.DataAccess
{
    public class DormProjectConctex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server =DESKTOP-S7MDANJ;Database=DormDb;Trusted_Connection=true");

        }


        public DbSet<Employee> Employee { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Block> Block { get; set; }
        public DbSet<Room> Room{ get; set; }
    }
}

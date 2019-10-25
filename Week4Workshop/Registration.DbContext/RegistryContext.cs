using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Registration.Models;

namespace Registration.DBContext
{
    public class RegistryContext : DbContext
    {
        public DbSet <User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Server=localhost;Database=RegistrationDB;user id=sa;password=fmi");
        }
    }
}

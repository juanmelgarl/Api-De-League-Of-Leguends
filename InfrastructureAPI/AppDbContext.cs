using DomainAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.IdentityModel;
using Microsoft.Identity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InfrastructureAPI
{
    public class AppDbContext  : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

         public DbSet<Campeones> Campeones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}

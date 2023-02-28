using System;  
using System.Collections.Generic;   
using System.Linq;
using AssignmentProject.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentProject;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions options) : base(options) ///constructor
    {
        
    }

    /*
     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<User>()
            .HasMany(b => b.project)
            .WithOne(e => e.user);
    }
    */
    public DbSet<User> Users { get; set; }
    
    public DbSet<Issue> issues { get; set; }

    public DbSet<Project> projects { get; set; }


    

    
}
﻿using System;
using System.Collections.Generic;
using System.Text;
using Eventique.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventique.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Photographer> Photographers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<WeddingHall> Hotels { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Admin> Admins { get; set; }




        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

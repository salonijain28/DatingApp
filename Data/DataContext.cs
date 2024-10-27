﻿
using API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace API.Data
{ 
    public class DataContext(DbContextOptions options) : DbContext(options) 
    {
            public DbSet<AppUser> Users { get; set; }
    }
    
}
using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options) //primary contructor
{
    public DbSet<AppUser> Users { get; set; }

}

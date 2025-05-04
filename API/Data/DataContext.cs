using System;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    // quesries the "AppUser" entity and creates the bridge between entity and DB
    public DbSet<AppUser> Users { get; set; }
}

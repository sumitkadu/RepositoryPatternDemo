﻿using Microsoft.EntityFrameworkCore;

namespace RepositoryPatternDemo.Domain.Models.EFCore
{
    public class MyMDBContext : DbContext
    {
        public MyMDBContext (DbContextOptions<MyMDBContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Star> Star { get; set; }
    }
}

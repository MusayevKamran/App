using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Persistance.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        //public virtual DbSet<ArticleCategory> ArticleCategories { get; set; }
        //public virtual DbSet<ArticleImages> ArticleImages { get; set; }
        public virtual DbSet<Article> Articles { get; set; }
        //public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}

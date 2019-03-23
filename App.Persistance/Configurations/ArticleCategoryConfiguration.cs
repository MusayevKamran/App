using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Persistance.Configurations
{
    public class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder.HasKey(a => new { a.ArticleId, a.CategoryId });

            //builder.HasOne(a => a.Article)
            //    .WithMany(b => b.ArticleCategory)
            //    .HasForeignKey(a => a.ArticleId)
            //    .HasConstraintName("FK_Article_Categories");

            builder.HasOne(a => a.Category)
                .WithMany(b => b.ArticleCategory)
                .HasForeignKey(a => a.CategoryId)
                .HasConstraintName("FK_Category_Articles");
        }
    }
}

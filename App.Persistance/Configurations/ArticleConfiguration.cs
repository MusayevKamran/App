using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Persistance.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasKey(a => a.ArticleId);

            builder.HasOne(a => a.User)
                   .WithMany(b => b.Articles)
                   .HasPrincipalKey(c => c.UserId)
                   .HasConstraintName("FK_Article_User");

            builder.HasMany(a => a.Images)
                   .WithOne(a => a.Article)
                   .HasPrincipalKey(a => a.ArticleId)
                   .HasConstraintName("FK_Article_Images");

            builder.HasMany(a => a.Comments)
                   .WithOne(a => a.Article)
                   .HasPrincipalKey(a => a.ArticleId)
                   .HasConstraintName("FK_Article_Comments");
        }
    }
}

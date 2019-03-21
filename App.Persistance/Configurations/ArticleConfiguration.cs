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
            builder.HasMany<Comment>(a => a.Comment)
                .WithOne(b => b.Article)
                .HasPrincipalKey(c => c.ArticleId)
                .HasConstraintName("FK_Article_Comments");
        }
    }
}

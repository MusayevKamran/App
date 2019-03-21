using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Persistance.Configurations
{
    public class ArticleImageConfiguration : IEntityTypeConfiguration<ArticleImages>
    {
        public void Configure(EntityTypeBuilder<ArticleImages> builder)
        {
            builder.HasKey(a => new { a.ArticleId, a.ImageId });

            builder.HasOne(a => a.Article)
                .WithMany(b => b.Images)
                .HasForeignKey(a => a.ArticleId)
                .HasConstraintName("FK_Article_Images");
        }
    }
}

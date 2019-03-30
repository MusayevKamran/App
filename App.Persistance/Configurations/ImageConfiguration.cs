using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace App.Persistance.Configurations
{
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {

            builder.HasOne(a => a.Article)
                .WithMany(a => a.Images)
                .HasPrincipalKey(a => a.ArticleId)
                .HasConstraintName("FK_Images_Article");
        }
    }
}

using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Persistance.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //builder.HasMany<Article>(a => a.Article)
            //   .WithOne(b => b.User)
            //   .HasPrincipalKey(c => c.UserId)
            //   .HasConstraintName("FK_User_Articles"); ;

            builder.HasMany<Comment>(a => a.Comment)
                .WithOne(b => b.User)
                .HasPrincipalKey(c => c.UserId)
                .HasConstraintName("FK_User_Comments"); ;
        }
    }
}
using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace App.Persistance.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(e => e.CategoryId).HasColumnName("CategoryID");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(e => e.Row).HasColumnType("Row");

        }
    }
}

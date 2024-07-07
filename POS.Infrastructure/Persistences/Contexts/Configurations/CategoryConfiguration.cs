using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POS.Domain.Entities;

namespace POS.Infrastructure.Persistences.Contexts.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .HasColumnName("CategoryId"); // We add this configuration to keep the relation with column name in db 
                //.ValueGeneratedOnAdd(); // Trying to stop the four (4) digits Id generation. It didn't work.

            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}

using CodeWiki.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeWiki.Infra.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreateAt);

            builder.Property(x => x.UpdateAt)
                .IsRequired();

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasMany(x => x.Subcategories)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId);
        }
    }
}

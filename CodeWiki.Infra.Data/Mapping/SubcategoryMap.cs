using CodeWiki.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeWiki.Infra.Data.Mapping
{
    public class SubcategoryMap : IEntityTypeConfiguration<Subcategory>
    {
        public void Configure(EntityTypeBuilder<Subcategory> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreateAt);

            builder.Property(x => x.UpdateAt)
                .IsRequired();

            builder.Property(x => x.Name)
                .HasMaxLength(80)
                .IsRequired();
        }
    }
}

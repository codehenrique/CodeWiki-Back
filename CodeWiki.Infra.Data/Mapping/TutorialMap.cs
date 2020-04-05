using CodeWiki.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeWiki.Infra.Data.Mapping
{
    public class TutorialMap : IEntityTypeConfiguration<Tutorial>
    {
        public void Configure(EntityTypeBuilder<Tutorial> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreateAt);

            builder.Property(x => x.UpdateAt)
                .IsRequired();

            builder.Property(x => x.Subject)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Content)
                .IsRequired();

            builder.Property(x => x.Observation)
                .HasMaxLength(600);

            builder.HasOne(x => x.Category)
                .WithMany(x => x.Tutorials)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Subcategory)
                .WithMany(x => x.Tutorials)
                .HasForeignKey(x => x.SubcategoryId)
                   .OnDelete(DeleteBehavior.Restrict)
;
        }
    }
}

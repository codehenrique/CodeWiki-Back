using CodeWiki.Domain.Entities;
using CodeWiki.Infra.Data.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CodeWiki.Infra.Data.Context
{
    public class CodeWikiContext : DbContext
    {
        public DbSet<Tutorial> Tutorials { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }

        public CodeWikiContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TutorialMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new SubcategoryMap());
        }
    }
}

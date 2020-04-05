using System.Collections.Generic;

namespace CodeWiki.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; private set; }

        public virtual ICollection<Subcategory> Subcategories { get; private set; }
        public virtual ICollection<Tutorial> Tutorials { get; private set; }


        public Category()
        {
            Subcategories = new List<Subcategory>();
            Tutorials = new List<Tutorial>();
        }
    }
}

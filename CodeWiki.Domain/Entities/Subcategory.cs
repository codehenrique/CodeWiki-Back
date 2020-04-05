using System.Collections.Generic;

namespace CodeWiki.Domain.Entities
{
    public class Subcategory : BaseEntity
    {
        public string Name { get; private set; }
        public int CategoryId { get; private set; }
        public virtual Category Category { get; private set; }
        public virtual ICollection<Tutorial> Tutorials { get; private set; }

        public Subcategory()
        {
            Tutorials = new List<Tutorial>();
        }
    }
}

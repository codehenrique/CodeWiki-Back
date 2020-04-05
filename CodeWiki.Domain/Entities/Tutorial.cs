namespace CodeWiki.Domain.Entities
{
    public class Tutorial : BaseEntity
    {
        public string Title { get; private set; }
        public string Subject { get; private set; }
        public string Content { get; private set; }
        public string Observation { get; private set; }
        public int CategoryId { get; private set; }
        public int SubcategoryId { get; private set; }
        public virtual Category Category { get; private set; }
        public virtual Subcategory Subcategory { get; private set; }
    }
}

namespace Survivor.Data.Entities
{
    public class Category : BaseEntity<int>
    {
        public string? Name { get; set; }

        public List<Competitor>? Competitors { get; set; } // Navigation property
    }
}

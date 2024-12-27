using System.ComponentModel.DataAnnotations.Schema;

namespace Survivor.Data.Entities
{
    public class Competitor : BaseEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CategoryId { get; set; } // Foreign key

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; } // Navigation property
    }
}

